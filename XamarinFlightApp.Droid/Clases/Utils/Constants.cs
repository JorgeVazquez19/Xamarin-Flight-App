using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinFlightApp.Droid.Clases.Utils
{
    public class Constants
    {
        private const string BASE_URL = "https://jsonplaceholder.typicode.com/";
        public const string COMMENTS_URL = BASE_URL + "comments";
    }
}