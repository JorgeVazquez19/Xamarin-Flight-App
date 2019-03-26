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
using XamarinFlightApp.Droid.Clases.Search;

namespace XamarinFlightApp.Droid.Clases.Profile
{
    public class ProfileFragment : Fragment, IAdapterClickListener
    {

        private TextView name;
        private TextView lastname;
        private TextView username;
        private Button changePass;
        private Switch switchNotifications;
        private Spinner filter;
        private RelativeLayout profile;
        private DataManager dataManager;
        private ProfileAdapter profileAdapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            dataManager = MyApplication.GetDataManager();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Profile, container, false);
            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            InitView(view);

            LoadComments();
        }

        public async void OnItemClicked(View view, int position)
        {

        }

        private void InitView(View view)
        {
            name = view.FindViewById<TextView>(Resource.Id.profile_name);
            lastname = view.FindViewById<TextView>(Resource.Id.profile_lastname);
            username = view.FindViewById<TextView>(Resource.Id.profile_username);
            changePass = view.FindViewById<Button>(Resource.Id.btn_changePass);
            switchNotifications = view.FindViewById<Switch>(Resource.Id.switch_notifications);
            filter = view.FindViewById<Spinner>(Resource.Id.spinner);
            profile = view.FindViewById<RelativeLayout>(Resource.Id.rProfile);
            profileAdapter = new ProfileAdapter();
            profileAdapter.SetListener(this);
            
        }

        private async void LoadComments()
        {

        }

        private void ShowProgressIndicator (bool visible)
        {

        }
    }
}