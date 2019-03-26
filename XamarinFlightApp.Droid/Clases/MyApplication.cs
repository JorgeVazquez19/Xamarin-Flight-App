using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFlightApp.Droid.Clases.Profile;

namespace XamarinFlightApp.Droid.Clases
{
    [Activity(Label = "MyApplication")]
    public class MyApplication : Application
    {
        private static DataManager dataManager;
        private string pathToDb;

        public MyApplication(IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            pathToDb = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "favorites.db3");
            dataManager = new DataManager(pathToDb);

            base.OnCreate();
        }

        public static DataManager GetDataManager()
        {
            return dataManager;
        }
    }
}