using Android.Views;

namespace XamarinFlightApp.Droid.Clases.Search
{
    internal interface IAdapterClickListener
    {
        void OnItemClicked(View view, int position);
    }
}