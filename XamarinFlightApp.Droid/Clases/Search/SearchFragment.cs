﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinFlightApp.Droid.Clases.Search
{
    public class SearchFragment : Fragment, IAdapterClickListener
    {

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Recuperamos la instancia desde la clase Application 
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
           
        }
        
        private async void LoadComments()
        {
            
        }
        
        private void ShowProgressIndicator(bool visible)
        {
            
        }
    }
}