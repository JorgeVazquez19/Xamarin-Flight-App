using System;
using Android;
using Android.App;
using Android.Content;
using Java.Lang;

namespace XamarinFirstApp.Droid.Common
{
    /*En esta clase vamos a manejar la carga de activities o fragments*/
    public class Navigation
    {
        //Metodo para cargar actividades
        public static void launchActivity(Activity activity)
        {
            throw new IllegalArgumentException("Not inplemented yet");
        }

        //Pasamos la actividad que ejecutara la carga y el fragmento a cargar
        public static void launchFragment(Activity context, Fragment fragment)
        {
            if (fragment != null)
            {
                //context.FragmentManager.BeginTransaction().Replace(Resource.Id.main_container, fragment).Commit();
            }
        }
    }
}