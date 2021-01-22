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

        internal async static Task<string> DeleteCar(Guid Id)
        {
            var deleteCarUrl = $"{BaseUrl}/{Id}";
            using (HttpClient httpClient = new HttpClient())
            {
                var carDeleteResponse = await httpClient.DeleteAsync(deleteCarUrl);
                var responseContent = await carDeleteResponse.Content.ReadAsStringAsync();
                return responseContent;
            }
        }

        internal async static Task<Car> UpdateCar(UpdateCar carUpdateModel, Guid id)
        {
            var updateCarUrl = $"{BaseUrl}/{id}";
            using (HttpClient httpClient = new HttpClient())
            {
                var url = new Uri(updateCarUrl);
                string jsonTranport = JsonConvert.SerializeObject(carUpdateModel);
                var jsonPayload = new StringContent(jsonTranport, Encoding.UTF8, "application/json");
                var updateCarResponse = await httpClient.PutAsync(url, jsonPayload);
                var responseContent = await updateCarResponse.Content.ReadAsStringAsync();
                var updatedCar = JsonConvert.DeserializeObject<Car>(responseContent);
                return updatedCar;
            }
        }

        internal static async Task<Car> AddCar(AddCar carAddModel)
        {
            var addCarUrl = $"{BaseUrl}/add";
            using (HttpClient httpClient = new HttpClient())
            {
                var url = new Uri(addCarUrl);
                string jsonTranport = JsonConvert.SerializeObject(carAddModel);
                var jsonPayload = new StringContent(jsonTranport, Encoding.UTF8, "application/json");
                var updateCarResponse = await httpClient.PostAsync(url, jsonPayload);
                var responseContent = await updateCarResponse.Content.ReadAsStringAsync();
                var updatedCar = JsonConvert.DeserializeObject<Car>(responseContent);
                return updatedCar;
            }
        }
    }
}
