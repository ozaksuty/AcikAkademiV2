package md56987f6cc1cad2bad7d1513f02edd2700;


public class CarouselViewRenderer_OnScrollListener
	extends android.support.v7.widget.RecyclerView.OnScrollListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrollStateChanged:(Landroid/support/v7/widget/RecyclerView;I)V:GetOnScrollStateChanged_Landroid_support_v7_widget_RecyclerView_IHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.CarouselViewRenderer+OnScrollListener, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CarouselViewRenderer_OnScrollListener.class, __md_methods);
	}


	public CarouselViewRenderer_OnScrollListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CarouselViewRenderer_OnScrollListener.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.CarouselViewRenderer+OnScrollListener, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScrollStateChanged (android.support.v7.widget.RecyclerView p0, int p1)
	{
		n_onScrollStateChanged (p0, p1);
	}

	private native void n_onScrollStateChanged (android.support.v7.widget.RecyclerView p0, int p1);

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
