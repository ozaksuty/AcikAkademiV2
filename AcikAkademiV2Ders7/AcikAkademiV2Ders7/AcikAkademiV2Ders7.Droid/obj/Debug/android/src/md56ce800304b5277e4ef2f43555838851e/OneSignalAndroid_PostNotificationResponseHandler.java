package md56ce800304b5277e4ef2f43555838851e;


public class OneSignalAndroid_PostNotificationResponseHandler
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.PostNotificationResponseHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lorg/json/JSONObject;)V:GetOnFailure_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignal.Android.Binding\n" +
			"n_onSuccess:(Lorg/json/JSONObject;)V:GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.OneSignal.OneSignalAndroid+PostNotificationResponseHandler, AcikAkademiV2Ders7.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OneSignalAndroid_PostNotificationResponseHandler.class, __md_methods);
	}


	public OneSignalAndroid_PostNotificationResponseHandler () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OneSignalAndroid_PostNotificationResponseHandler.class)
			mono.android.TypeManager.Activate ("Com.OneSignal.OneSignalAndroid+PostNotificationResponseHandler, AcikAkademiV2Ders7.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (org.json.JSONObject p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (org.json.JSONObject p0);


	public void onSuccess (org.json.JSONObject p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (org.json.JSONObject p0);

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
