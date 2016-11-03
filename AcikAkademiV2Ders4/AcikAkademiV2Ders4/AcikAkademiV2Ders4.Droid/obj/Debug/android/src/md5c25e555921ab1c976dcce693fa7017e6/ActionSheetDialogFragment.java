package md5c25e555921ab1c976dcce693fa7017e6;


public class ActionSheetDialogFragment
	extends md5c25e555921ab1c976dcce693fa7017e6.AbstractDialogFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dismiss:()V:GetDismissHandler\n" +
			"";
		mono.android.Runtime.register ("Acr.UserDialogs.Fragments.ActionSheetDialogFragment, Acr.UserDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionSheetDialogFragment.class, __md_methods);
	}


	public ActionSheetDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionSheetDialogFragment.class)
			mono.android.TypeManager.Activate ("Acr.UserDialogs.Fragments.ActionSheetDialogFragment, Acr.UserDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void dismiss ()
	{
		n_dismiss ();
	}

	private native void n_dismiss ();

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
