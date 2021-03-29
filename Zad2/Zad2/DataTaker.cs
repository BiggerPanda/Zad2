using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Zad2
{
    
    class DataTaker
    {
        static float latitude = 50;
        static float longitude = 50;
        string apiKey = "65bc6f756e5518bc1dcb8005662d960d";
        string apiCall = "http://api.openweathermap.org/data/2.5/air_pollution?lat=" + latitude + "&lon=" + longitude + "&appid={API key}";
    
        public async Task CallerAsync()
        {
            string call = apiCall + apiKey;
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            Console.WriteLine(response);

        }
    }

}
