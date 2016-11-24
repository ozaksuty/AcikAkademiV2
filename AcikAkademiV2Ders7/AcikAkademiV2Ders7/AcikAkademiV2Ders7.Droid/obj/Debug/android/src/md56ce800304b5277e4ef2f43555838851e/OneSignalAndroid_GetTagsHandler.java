package md56ce800304b5277e4ef2f43555838851e;


public class OneSignalAndroid_GetTagsHandler
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.GetTagsHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_tagsAvailable:(Lorg/json/JSONObject;)V:GetTagsAvailable_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IGetTagsHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.OneSignal.OneSignalAndroid+GetTagsHandler, AcikAkademiV2Ders7.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OneSignalAndroid_GetTagsHandler.class, __md_methods);
	}


	public OneSignalAndroid_GetTagsHandler () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OneSignalAndroid_GetTagsHandler.class)
			mono.android.TypeManager.Activate ("Com.OneSignal.OneSignalAndroid+GetTagsHandler, AcikAkademiV2Ders7.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void tagsAvailable (org.json.JSONObject p0)
	{
		n_tagsAvailable (p0);
	}

	private native void n_tagsAvailable (org.json.JSONObject p0);

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
