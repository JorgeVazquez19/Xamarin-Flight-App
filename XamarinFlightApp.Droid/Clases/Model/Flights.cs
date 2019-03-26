using System;

namespace XamarinFlightApp.Droid.Clases.Model
{
    public class Flight
    {
        //[PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}