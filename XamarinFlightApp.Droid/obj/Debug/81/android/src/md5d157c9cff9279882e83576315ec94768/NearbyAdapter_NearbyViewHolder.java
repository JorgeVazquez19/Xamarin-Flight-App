package md5d157c9cff9279882e83576315ec94768;


public class NearbyAdapter_NearbyViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XamarinFlightApp.Droid.Clases.Nearby.NearbyAdapter+NearbyViewHolder, XamarinFlightApp.Droid", NearbyAdapter_NearbyViewHolder.class, __md_methods);
	}


	public NearbyAdapter_NearbyViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == NearbyAdapter_NearbyViewHolder.class)
			mono.android.TypeManager.Activate ("XamarinFlightApp.Droid.Clases.Nearby.NearbyAdapter+NearbyViewHolder, XamarinFlightApp.Droid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
