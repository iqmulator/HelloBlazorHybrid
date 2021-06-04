using System;
using System.Threading;
using System.Threading.Tasks;
using RestEase;
using HelloBlazorHybrid.Abstractions;

namespace HelloBlazorHybrid.UI.Services
{
    [BasePath("counter")]
    public interface ICounterClient
    {
        [Post("increment")]
        Task Increment(CancellationToken cancellationToken = default);

        [Get("get")]
        Task<int> Get(CancellationToken cancellationToken = default);
    }

    [BasePath("fetchdata")]
    public interface IWeatherForecastClient
    {
        [Get("getForecastAsync")]
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate, CancellationToken cancellationToken = default);
    }
}