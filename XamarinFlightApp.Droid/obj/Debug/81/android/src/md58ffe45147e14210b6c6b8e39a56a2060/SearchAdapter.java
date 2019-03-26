package md58ffe45147e14210b6c6b8e39a56a2060;


public class SearchAdapter
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinFlightApp.Droid.Clases.Search.SearchAdapter, XamarinFlightApp.Droid", SearchAdapter.class, __md_methods);
	}


	public SearchAdapter ()
	{
		super ();
		if (getClass () == SearchAdapter.class)
			mono.android.TypeManager.Activate ("XamarinFlightApp.Droid.Clases.Search.SearchAdapter, XamarinFlightApp.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
