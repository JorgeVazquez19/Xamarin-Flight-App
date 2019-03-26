
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFirstApp.Data.Service.Interface;
using XamarinFlightApp.Droid.Clases.API;
using XamarinFlightApp.Droid.Clases.Local;
using XamarinFlightApp.Droid.Clases.Model;
namespace XamarinFlightApp.Droid.Clases.Profile
{
    public class DataManager : IDataManager
    {
        private FlightsDatabase flightsDatabase;
        private FlightApi flightsApi;

        public DataManager(string pathToDb)
        {
            flightsApi = new FlightApi();
            flightsDatabase = new FlightsDatabase(/*pathToDb*/);
        }
        public async Task<List<Flight>> GetFlights()
        {
            return await flightsApi.GetAllFlights();
        }
    }
}