package md5b5f5759c6fc087071f061e43b2381150;


public class ForgotPassword
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
		mono.android.Runtime.register ("XamarinFlightApp.Droid.Classes.ForgotPassword, XamarinFlightApp.Droid", ForgotPassword.class, __md_methods);
	}


	public ForgotPassword ()
	{
		super ();
		if (getClass () == ForgotPassword.class)
			mono.android.TypeManager.Activate ("XamarinFlightApp.Droid.Classes.ForgotPassword, XamarinFlightApp.Droid", "", this, new java.lang.Object[] {  });
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
