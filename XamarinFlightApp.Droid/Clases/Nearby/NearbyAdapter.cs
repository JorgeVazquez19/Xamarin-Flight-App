using System;
using System.Collections.Generic;
using System.Linq;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using XamarinFlightApp.Droid.Clases.Model;
using XamarinFlightApp.Droid.Clases.Search;

namespace XamarinFlightApp.Droid.Clases.Nearby
{
    public class NearbyAdapter : RecyclerView.Adapter
    {
        private List<Flight> flights;
        private static IAdapterClickListener adapterClickListener;

        public NearbyAdapter()
        {
            flights = new List<Flight>();
        }

        public override int ItemCount
        {
            get { return flights.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            NearbyViewHolder ch = holder as NearbyViewHolder;
            ch.bind(flights[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.itemFlightNearby, parent, false);
            NearbyViewHolder ch = new NearbyViewHolder(itemView);
            return ch;
        }

        public Flight GetItemAtPosition(int position)
        {
            return flights.ElementAt(position);
        }

        

        public void RefreshData(List<Flight> updateList)
        {
            if (updateList.Any())
            {
                flights.Clear();
                flights = updateList;
                NotifyDataSetChanged();
            }
        }

        protected class NearbyViewHolder : RecyclerView.ViewHolder, View.IOnClickListener
        {
            private TextView title;
            private TextView body;
            private Button iconFav;

            public NearbyViewHolder(View itemView) : base(itemView)
            {
                title = itemView.FindViewById<TextView>(Resource.Id.item_title);
                body = itemView.FindViewById<TextView>(Resource.Id.item_body);
                iconFav = itemView.FindViewById<Button>(Resource.Id.item_fav);
                iconFav.SetOnClickListener(this);
            }

            public void bind(Flight item)
            {
                title.Text = item.Name;
                body.Text = item.Body;
            }

            public void OnClick(View v)
            {
                adapterClickListener.OnItemClicked(v, AdapterPosition);
            }
            
        }

        internal void SetListener(NearbyFragment nearbyFragment)
        {
            throw new NotImplementedException();
        }
    }
}