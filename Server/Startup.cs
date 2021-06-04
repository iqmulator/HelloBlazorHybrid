// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using Stl.Fusion;
// using Stl.Fusion.Extensions;
//
// namespace HelloBlazorHybrid.Server
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }
//
//         public IConfiguration Configuration { get; }
//
//         // This method gets called by the runtime. Use this method to add services to the container.
//         // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//         public void ConfigureServices(IServiceCollection services)
//         {
//             // Fusion service
//             var fusion = services.AddFusion();
//             fusion.AddFusionTime(); // IFusionTime is one of built-in compute services you can use
//             // fusion.AddComputeService<CounterService>();
//             // fusion.AddComputeService<ChatService>();
//             // fusion.AddComputeService<ChatBotService>();
//
//             // This is just to make sure ChatBotService.StartAsync is called on startup
//             // services.AddHostedService(c => c.GetRequiredService<ChatBotService>());
//
//             // Default update delay is 0.5s
//             services.AddTransient<IUpdateDelayer>(_ => new UpdateDelayer(0.5));
//
//             // Web
//             services.AddRazorPages();
//             services.AddServerSideBlazor();
//         }
//
//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Error");
//                 // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                 app.UseHsts();
//             }
//
//             app.UseHttpsRedirection();
//             app.UseStaticFiles();
//
//             app.UseRouting();
//
//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapBlazorHub();
//                 endpoints.MapFallbackToPage("/_Host");
//             });
//         }
//     }
// }


using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using HelloBlazorHybrid.Abstractions;
using HelloBlazorHybrid.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Stl.DependencyInjection;
using Stl.Fusion;
using Stl.Fusion.Authentication;
using Stl.Fusion.Blazor;
using Stl.Fusion.Bridge;
using Stl.Fusion.Client;
using Stl.Fusion.Server;

namespace HelloBlazorHybrid.Server
{
    public class Startup
    {
        private IConfiguration Cfg { get; }
        private IWebHostEnvironment Env { get; }
        private ServerSettings ServerSettings { get; set; } = null!;
        private ILogger Log { get; set; } = NullLogger<Startup>.Instance;

        public Startup(IConfiguration cfg, IWebHostEnvironment environment)
        {
            Cfg = cfg;
            Env = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Logging
            services.AddLogging(logging => {
                logging.ClearProviders();
                logging.AddConsole();
                logging.SetMinimumLevel(LogLevel.Information);
                if (Env.IsDevelopment()) {
                    logging.AddFilter("Microsoft", LogLevel.Warning);
                    logging.AddFilter("Microsoft.AspNetCore.Hosting", LogLevel.Information);
                    logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Information);
                    logging.AddFilter("Stl.Fusion.Operations", LogLevel.Information);
                }
            });

            // Creating Log and ServerSettings as early as possible
            services.AddSettings<ServerSettings>("Server");
            services.AddSettings<BlazorModeHelper>();
#pragma warning disable ASP0000
            var tmpServices = services.BuildServiceProvider();
#pragma warning restore ASP0000
            Log = tmpServices.GetRequiredService<ILogger<Startup>>();
            ServerSettings = tmpServices.GetRequiredService<ServerSettings>();

            // Fusion
            var fusion = services.AddFusion();
            var fusionClient = fusion.AddRestEaseClient();
            var fusionServer = fusion.AddWebServer();
            services.AddSingleton(new Publisher.Options() { Id = ServerSettings.PublisherId });
            services.AddSingleton(new PresenceService.Options() { UpdatePeriod = TimeSpan.FromMinutes(1) });
            services.AddScoped<BlazorModeHelper>();
            
            // Fusion services
            fusion.AddComputeService<ICounterService, CounterService>();
            fusion.AddComputeService<IWeatherForecastService, WeatherForecastService>();

            // Shared UI services
            UI.Program.ConfigureSharedServices(services);
            
            // Web
            services.Configure<ForwardedHeadersOptions>(options => {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                options.KnownNetworks.Clear();
                options.KnownProxies.Clear();
            });
            services.AddRouting();
            services.AddMvc().AddApplicationPart(Assembly.GetExecutingAssembly());
            services.AddServerSideBlazor(o => o.DetailedErrors = true);
        }

        public void Configure(IApplicationBuilder app, ILogger<Startup> log)
        {
            if (ServerSettings.AssumeHttps) {
                Log.LogInformation("AssumeHttps on");
                app.Use((context, next) => {
                    context.Request.Scheme = "https";
                    return next();
                });
            }

            // This server serves static content from Blazor Client,
            // and since we don't copy it to local wwwroot,
            // we need to find Client's wwwroot in bin/(Debug/Release) folder
            // and set it as this server's content root.
            var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
            var binCfgPart = Regex.Match(baseDir, @"[\\/]bin[\\/]\w+[\\/]").Value;
            var wwwRootPath = Path.Combine(baseDir, "wwwroot");
            if (!Directory.Exists(Path.Combine(wwwRootPath, "_framework")))
                // This is a regular build, not a build produced w/ "publish",
                // so we remap wwwroot to the client's wwwroot folder
                wwwRootPath = Path.GetFullPath(Path.Combine(baseDir, $"../../../../UI/{binCfgPart}/net5.0/wwwroot"));
            Env.WebRootPath = wwwRootPath;
            Env.WebRootFileProvider = new PhysicalFileProvider(Env.WebRootPath);
            StaticWebAssetsLoader.UseStaticWebAssets(Env, Cfg);

            if (Env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseForwardedHeaders(new ForwardedHeadersOptions {
                ForwardedHeaders = ForwardedHeaders.XForwardedProto
            });

            app.UseWebSockets(new WebSocketOptions() {
                KeepAliveInterval = TimeSpan.FromSeconds(30),
            });
            // app.UseFusionSession();

            // Static + Swagger
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            // API controllers
            app.UseRouting();
            // app.UseAuthentication();
            // app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapBlazorHub();
                endpoints.MapFusionWebSocketServer();
                endpoints.MapControllers();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
