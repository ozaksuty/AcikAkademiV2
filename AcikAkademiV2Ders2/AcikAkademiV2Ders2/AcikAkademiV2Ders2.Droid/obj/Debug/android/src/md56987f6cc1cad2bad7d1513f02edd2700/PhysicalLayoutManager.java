package md56987f6cc1cad2bad7d1513f02edd2700;


public class PhysicalLayoutManager
	extends android.support.v7.widget.RecyclerView.LayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdapterChanged:(Landroid/support/v7/widget/RecyclerView$Adapter;Landroid/support/v7/widget/RecyclerView$Adapter;)V:GetOnAdapterChanged_Landroid_support_v7_widget_RecyclerView_Adapter_Landroid_support_v7_widget_RecyclerView_Adapter_Handler\n" +
			"n_onItemsChanged:(Landroid/support/v7/widget/RecyclerView;)V:GetOnItemsChanged_Landroid_support_v7_widget_RecyclerView_Handler\n" +
			"n_onItemsAdded:(Landroid/support/v7/widget/RecyclerView;II)V:GetOnItemsAdded_Landroid_support_v7_widget_RecyclerView_IIHandler\n" +
			"n_onItemsRemoved:(Landroid/support/v7/widget/RecyclerView;II)V:GetOnItemsRemoved_Landroid_support_v7_widget_RecyclerView_IIHandler\n" +
			"n_onItemsMoved:(Landroid/support/v7/widget/RecyclerView;III)V:GetOnItemsMoved_Landroid_support_v7_widget_RecyclerView_IIIHandler\n" +
			"n_onItemsUpdated:(Landroid/support/v7/widget/RecyclerView;II)V:GetOnItemsUpdated_Landroid_support_v7_widget_RecyclerView_IIHandler\n" +
			"n_generateDefaultLayoutParams:()Landroid/support/v7/widget/RecyclerView$LayoutParams;:GetGenerateDefaultLayoutParamsHandler\n" +
			"n_findViewByPosition:(I)Landroid/view/View;:GetFindViewByPosition_IHandler\n" +
			"n_scrollToPosition:(I)V:GetScrollToPosition_IHandler\n" +
			"n_smoothScrollToPosition:(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/RecyclerView$State;I)V:GetSmoothScrollToPosition_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_RecyclerView_State_IHandler\n" +
			"n_canScrollHorizontally:()Z:GetCanScrollHorizontallyHandler\n" +
			"n_canScrollVertically:()Z:GetCanScrollVerticallyHandler\n" +
			"n_supportsPredictiveItemAnimations:()Z:GetSupportsPredictiveItemAnimationsHandler\n" +
			"n_onLayoutChildren:(Landroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)V:GetOnLayoutChildren_Landroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_scrollHorizontallyBy:(ILandroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)I:GetScrollHorizontallyBy_ILandroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_scrollVerticallyBy:(ILandroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)I:GetScrollVerticallyBy_ILandroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.PhysicalLayoutManager, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PhysicalLayoutManager.class, __md_methods);
	}


	public PhysicalLayoutManager () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PhysicalLayoutManager.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.PhysicalLayoutManager, Xamarin.Forms.CarouselView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAdapterChanged (android.support.v7.widget.RecyclerView.Adapter p0, android.support.v7.widget.RecyclerView.Adapter p1)
	{
		n_onAdapterChanged (p0, p1);
	}

	private native void n_onAdapterChanged (android.support.v7.widget.RecyclerView.Adapter p0, android.support.v7.widget.RecyclerView.Adapter p1);


	public void onItemsChanged (android.support.v7.widget.RecyclerView p0)
	{
		n_onItemsChanged (p0);
	}

	private native void n_onItemsChanged (android.support.v7.widget.RecyclerView p0);


	public void onItemsAdded (android.support.v7.widget.RecyclerView p0, int p1, int p2)
	{
		n_onItemsAdded (p0, p1, p2);
	}

	private native void n_onItemsAdded (android.support.v7.widget.RecyclerView p0, int p1, int p2);


	public void onItemsRemoved (android.support.v7.widget.RecyclerView p0, int p1, int p2)
	{
		n_onItemsRemoved (p0, p1, p2);
	}

	private native void n_onItemsRemoved (android.support.v7.widget.RecyclerView p0, int p1, int p2);


	public void onItemsMoved (android.support.v7.widget.RecyclerView p0, int p1, int p2, int p3)
	{
		n_onItemsMoved (p0, p1, p2, p3);
	}

	private native void n_onItemsMoved (android.support.v7.widget.RecyclerView p0, int p1, int p2, int p3);


	public void onItemsUpdated (android.support.v7.widget.RecyclerView p0, int p1, int p2)
	{
		n_onItemsUpdated (p0, p1, p2);
	}

	private native void n_onItemsUpdated (android.support.v7.widget.RecyclerView p0, int p1, int p2);


	public android.support.v7.widget.RecyclerView.LayoutParams generateDefaultLayoutParams ()
	{
		return n_generateDefaultLayoutParams ();
	}

	private native android.support.v7.widget.RecyclerView.LayoutParams n_generateDefaultLayoutParams ();


	public android.view.View findViewByPosition (int p0)
	{
		return n_findViewByPosition (p0);
	}

	private native android.view.View n_findViewByPosition (int p0);


	public void scrollToPosition (int p0)
	{
		n_scrollToPosition (p0);
	}

	private native void n_scrollToPosition (int p0);


	public void smoothScrollToPosition (android.support.v7.widget.RecyclerView p0, android.support.v7.widget.RecyclerView.State p1, int p2)
	{
		n_smoothScrollToPosition (p0, p1, p2);
	}

	private native void n_smoothScrollToPosition (android.support.v7.widget.RecyclerView p0, android.support.v7.widget.RecyclerView.State p1, int p2);


	public boolean canScrollHorizontally ()
	{
		return n_canScrollHorizontally ();
	}

	private native boolean n_canScrollHorizontally ();


	public boolean canScrollVertically ()
	{
		return n_canScrollVertically ();
	}

	private native boolean n_canScrollVertically ();


	public boolean supportsPredictiveItemAnimations ()
	{
		return n_supportsPredictiveItemAnimations ();
	}

	private native boolean n_supportsPredictiveItemAnimations ();


	public void onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1)
	{
		n_onLayoutChildren (p0, p1);
	}

	private native void n_onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1);


	public int scrollHorizontallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2)
	{
		return n_scrollHorizontallyBy (p0, p1, p2);
	}

	private native int n_scrollHorizontallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2);


	public int scrollVerticallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2)
	{
		return n_scrollVerticallyBy (p0, p1, p2);
	}

	private native int n_scrollVerticallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2);


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

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
