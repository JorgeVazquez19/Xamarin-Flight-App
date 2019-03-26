using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using XamarinFlightApp.Droid.Clases.Interfaces;
using XamarinFlightApp.Droid.Clases.Model;
using XamarinFlightApp.Droid.Clases.Utils;

namespace XamarinFlightApp.Droid.Clases.API
{
    public class FlightApi : IFlihtsApi
    {
        private readonly HttpClient httpClient;

        public FlightApi()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Flight>> GetAllFlights()
        {
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var commentsJson = await httpClient.GetStringAsync(Constants.COMMENTS_URL);
            return JsonConvert.DeserializeObject<List<Flight>>(commentsJson);
        }
    }
}