using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace NUGETRef
{
    class Program
    {
        static List<Person> People = new List<Person>();
        static void Main(string[] args)
        {
            GetPeople();
        }
        static void GetPeople()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var apiResponse = httpClient.GetAsync("https://my.api.mockaroo.com/employees.json?key=9a55a0e0").Result;
                if (apiResponse.IsSuccessStatusCode)
                {
                    var apiResponseString = apiResponse.Content.ReadAsStringAsync().Result;
                    People = JsonConvert.DeserializeObject<List<Person>>(apiResponseString);
                }
            };
            People.Print();
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

}
