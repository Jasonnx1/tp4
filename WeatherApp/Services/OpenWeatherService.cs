using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Services
{
    class OpenWeatherService : ITemperatureService
    {

        private OpenWeatherProcessor owp { get; set; }
        public TemperatureModel LastTemp { get; set; }

        public async Task<TemperatureModel> GetTempAsync()
        {
            var a = await owp.GetCurrentWeatherAsync();          
            LastTemp = new TemperatureModel();
            LastTemp.Temperature = a.Main.Temperature;
            LastTemp.DateTime = DateTime.Now;
            return LastTemp;

        }

 

        public OpenWeatherService(String apiKey)
        {
            ApiHelper.InitializeClient();
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }





    }
}
