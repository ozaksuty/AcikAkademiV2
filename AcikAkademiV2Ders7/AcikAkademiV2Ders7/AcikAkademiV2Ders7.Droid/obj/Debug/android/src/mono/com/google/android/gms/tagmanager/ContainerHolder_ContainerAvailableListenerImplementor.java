package mono.com.google.android.gms.tagmanager;


public class ContainerHolder_ContainerAvailableListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.tagmanager.ContainerHolder.ContainerAvailableListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onContainerAvailable:(Lcom/google/android/gms/tagmanager/ContainerHolder;Ljava/lang/String;)V:GetOnContainerAvailable_Lcom_google_android_gms_tagmanager_ContainerHolder_Ljava_lang_String_Handler:Android.Gms.Tagmanager.IContainerHolderContainerAvailableListenerInvoker, Xamarin.GooglePlayServices.Analytics\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Tagmanager.IContainerHolderContainerAvailableListenerImplementor, Xamarin.GooglePlayServices.Analytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ContainerHolder_ContainerAvailableListenerImplementor.class, __md_methods);
	}


	public ContainerHolder_ContainerAvailableListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContainerHolder_ContainerAvailableListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Tagmanager.IContainerHolderContainerAvailableListenerImplementor, Xamarin.GooglePlayServices.Analytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onContainerAvailable (com.google.android.gms.tagmanager.ContainerHolder p0, java.lang.String p1)
	{
		n_onContainerAvailable (p0, p1);
	}

	private native void n_onContainerAvailable (com.google.android.gms.tagmanager.ContainerHolder p0, java.lang.String p1);

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
