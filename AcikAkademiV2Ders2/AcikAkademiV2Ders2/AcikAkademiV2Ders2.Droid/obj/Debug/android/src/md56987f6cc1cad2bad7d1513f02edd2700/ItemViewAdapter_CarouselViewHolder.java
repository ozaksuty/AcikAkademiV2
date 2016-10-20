package md56987f6cc1cad2bad7d1513f02edd2700;


public class ItemViewAdapter_CarouselViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.ItemViewAdapter+CarouselViewHolder, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ItemViewAdapter_CarouselViewHolder.class, __md_methods);
	}


	public ItemViewAdapter_CarouselViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ItemViewAdapter_CarouselViewHolder.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.ItemViewAdapter+CarouselViewHolder, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
