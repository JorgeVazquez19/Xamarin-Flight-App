package md508417a53da15e0d68d96b49fe097cc54;


public class ProfileAdapter
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
		mono.android.Runtime.register ("XamarinFlightApp.Droid.Clases.Profile.ProfileAdapter, XamarinFlightApp.Droid", ProfileAdapter.class, __md_methods);
	}


	public ProfileAdapter ()
	{
		super ();
		if (getClass () == ProfileAdapter.class)
			mono.android.TypeManager.Activate ("XamarinFlightApp.Droid.Clases.Profile.ProfileAdapter, XamarinFlightApp.Droid", "", this, new java.lang.Object[] {  });
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
