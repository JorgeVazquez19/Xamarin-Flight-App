using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using XamarinFirstApp.Droid.Common;
using XamarinFlightApp.Droid.Clases.Favorites;
using XamarinFlightApp.Droid.Clases.Nearby;
using XamarinFlightApp.Droid.Clases.Profile;
using XamarinFlightApp.Droid.Clases.Search;

namespace XamarinFlightApp.Droid.Classes
{
    [Activity(Label = "Home Page", Theme = "@style/AppTheme")]
    public class DashBoard : Activity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private BottomNavigationView bottomBar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DashboardDesign);

            //Inicializamos los componentes de la vista
            initView();

            //Cargamos el fragment por defecto
            Navigation.launchFragment(this,new ProfileFragment());
        }


        private void initView()
        {
            bottomBar = FindViewById<BottomNavigationView>(Resource.Id.bottom_bar);
            bottomBar.SetOnNavigationItemSelectedListener(this);
        }

        //Manejamos la carga de fragmentos dependiendo del item seleccionado
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.nav_search:
                    Navigation.launchFragment(this,new SearchFragment());
                    return true;
                case Resource.Id.nav_favorites:
                    Navigation.launchFragment(this,new FavoritesFragment());
                    return true;
                case Resource.Id.nav_nearby:
                    Navigation.launchFragment(this, new NearbyFragment());
                    return true;
                case Resource.Id.nav_profile:
                    Navigation.launchFragment(this, new ProfileFragment());
                    return true;
            }

            return false;
        }
    }
}