using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using XamarinFlightApp.Droid.Clases.Profile;
using XamarinFlightApp.Droid.Clases.Search;

namespace XamarinFlightApp.Droid.Clases.Nearby
{
    public class NearbyFragment : Fragment, IAdapterClickListener
    {
        private ContentLoadingProgressBar pbLoading;
        private RecyclerView rvListComments;
        private NearbyAdapter adapter;
        private DataManager dataManager;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Recuperamos la instancia desde la clase Application 
            dataManager = MyApplication.GetDataManager();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.NearbyDesign, container, false);

        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            //Inicializamos los componentes de la vista
            InitView(view);

            //Cargamos los comentarios de la llamada al servicio
            LoadComments();
        }

        //Añadiremos el comentario a nuestra base de datos de favoritos
        public async void OnItemClicked(View view, int position)
        {
            
        }

        private void InitView(View view)
        {
            pbLoading = view.FindViewById<ContentLoadingProgressBar>(Resource.Id.pb_loading_indicator);
            rvListComments = view.FindViewById<RecyclerView>(Resource.Id.rv_list_comments);
            rvListComments.SetLayoutManager(new LinearLayoutManager(Context));
            rvListComments.HasFixedSize = true;
            adapter = new NearbyAdapter();
            adapter.SetListener(this);
            rvListComments.SetAdapter(adapter);

        }

        //Cargamos la lista de la llamada al servicio, mientras se realiza el proceso
        //mostramos un indicador de carga y ocultamos la lista para que sea visible el
        //indicador
        private async void LoadComments()
        {
            ShowProgressIndicator(true);

            var list = await dataManager.GetFlights();

            ShowProgressIndicator(false);

            adapter.RefreshData(list);
        }

        //Mostramos el indicador de carga o dependiendo del valor visible
        private void ShowProgressIndicator(bool visible)
        {
            pbLoading.Visibility = visible ? ViewStates.Visible : ViewStates.Gone;
            rvListComments.Visibility = visible ? ViewStates.Gone : ViewStates.Visible;
        }
    }
}