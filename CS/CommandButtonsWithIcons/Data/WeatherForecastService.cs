using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommandButtonsWithIcons.Data
{
    public class WeatherForecastService
    {
        public string[] Summaries = new[]
        {
            "Hot", "Warm", "Cold", "Freezing"
        };

        private List<WeatherForecast> CreateForecast() {
            var rng = new Random();
            DateTime startDate = DateTime.Now;
            return Enumerable.Range(1, 15).Select(index => new WeatherForecast {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }

        public List<WeatherForecast> Forecasts { get; set; }
        public WeatherForecastService() {
            Forecasts = CreateForecast();
        }
        public Task<IEnumerable<WeatherForecast>> GetForecastAsync(CancellationToken ct = default) {
            return Task.FromResult<IEnumerable<WeatherForecast>>(Forecasts);
        }
        public Task<string[]> GetSummariesAsync() {
            return Task.FromResult(Summaries);
        }
        void InsertInternal(IDictionary<string, object> newValue) {
            var dataItem = new WeatherForecast();
            Update(dataItem, newValue);
            Forecasts.Insert(0, dataItem);
        }
        public Task Insert(IDictionary<string, object> newValue) {
            InsertInternal(newValue);
            return Task.CompletedTask;
        }
        void RemoveInternal(WeatherForecast dataItem) {
            Forecasts.Remove(dataItem);
        }
        public Task Remove(WeatherForecast dataItem) {
            RemoveInternal(dataItem);
            return Task.CompletedTask;
        }
        void UpdateInternal(WeatherForecast dataItem, IDictionary<string, object> newValue) {
            foreach (var field in newValue.Keys) {
                switch (field) {
                    case "Date":
                        dataItem.Date = (DateTime)newValue[field];
                        break;
                    case "Summary":
                        dataItem.Summary = (string)newValue[field];
                        break;
                    case "TemperatureC":
                        int intValue = 0;
                        if (Int32.TryParse((string)newValue[field], out intValue)) {
                            dataItem.TemperatureC = intValue;
                        }
                        break;
                }
            }
        }
        public Task Update(WeatherForecast dataItem, IDictionary<string, object> newValue) {
            UpdateInternal(dataItem, newValue);
            return Task.CompletedTask;
        }
    }
}
