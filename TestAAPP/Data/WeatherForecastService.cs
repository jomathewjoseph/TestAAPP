using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAAPP.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        //{
        //    var rng = new Random();
        //    return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = startDate.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    }).ToArray());
        //}
        public async IAsyncEnumerable<int> GetForecastAsync()
        {
            for (int i = 1; i <= 100 ; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
