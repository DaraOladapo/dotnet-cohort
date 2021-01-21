using CarsWebLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarDesktopApp
{
    public class Services
    {
        private static string BaseUrl = "http://localhost:81/api/cars";
        internal async static Task<List<Car>> GetAllCars()
        {
            var allCarsUrl = $"{BaseUrl}/all";
            using (HttpClient httpClient = new HttpClient())
            {
                var allCarsResponse = await httpClient.GetStringAsync(allCarsUrl);
                var allCars = JsonConvert.DeserializeObject<List<Car>>(allCarsResponse);
                return allCars;
            }
        }
    }
}
