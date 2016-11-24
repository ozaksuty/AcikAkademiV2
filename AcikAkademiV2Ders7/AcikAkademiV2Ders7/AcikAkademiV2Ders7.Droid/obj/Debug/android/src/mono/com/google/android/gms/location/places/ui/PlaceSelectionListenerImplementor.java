package mono.com.google.android.gms.location.places.ui;


public class PlaceSelectionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.location.places.ui.PlaceSelectionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/google/android/gms/common/api/Status;)V:GetOnError_Lcom_google_android_gms_common_api_Status_Handler:Android.Gms.Location.Places.UI.IPlaceSelectionListenerInvoker, Xamarin.GooglePlayServices.Location\n" +
			"n_onPlaceSelected:(Lcom/google/android/gms/location/places/Place;)V:GetOnPlaceSelected_Lcom_google_android_gms_location_places_Place_Handler:Android.Gms.Location.Places.UI.IPlaceSelectionListenerInvoker, Xamarin.GooglePlayServices.Location\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Location.Places.UI.IPlaceSelectionListenerImplementor, Xamarin.GooglePlayServices.Location, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlaceSelectionListenerImplementor.class, __md_methods);
	}


	public PlaceSelectionListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlaceSelectionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Location.Places.UI.IPlaceSelectionListenerImplementor, Xamarin.GooglePlayServices.Location, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (com.google.android.gms.common.api.Status p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.google.android.gms.common.api.Status p0);


	public void onPlaceSelected (com.google.android.gms.location.places.Place p0)
	{
		n_onPlaceSelected (p0);
	}

	private native void n_onPlaceSelected (com.google.android.gms.location.places.Place p0);

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
