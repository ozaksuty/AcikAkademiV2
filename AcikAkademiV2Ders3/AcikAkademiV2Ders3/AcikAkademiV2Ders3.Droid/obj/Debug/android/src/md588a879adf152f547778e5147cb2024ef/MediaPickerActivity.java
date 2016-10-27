package md588a879adf152f547778e5147cb2024ef;


public class MediaPickerActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		android.media.MediaScannerConnection.OnScanCompletedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSaveInstanceState:(Landroid/os/Bundle;)V:GetOnSaveInstanceState_Landroid_os_Bundle_Handler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onScanCompleted:(Ljava/lang/String;Landroid/net/Uri;)V:GetOnScanCompleted_Ljava_lang_String_Landroid_net_Uri_Handler:Android.Media.MediaScannerConnection/IOnScanCompletedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Plugin.Media.MediaPickerActivity, Plugin.Media, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", MediaPickerActivity.class, __md_methods);
	}


	public MediaPickerActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MediaPickerActivity.class)
			mono.android.TypeManager.Activate ("Plugin.Media.MediaPickerActivity, Plugin.Media, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSaveInstanceState (android.os.Bundle p0)
	{
		n_onSaveInstanceState (p0);
	}

	private native void n_onSaveInstanceState (android.os.Bundle p0);


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onScanCompleted (java.lang.String p0, android.net.Uri p1)
	{
		n_onScanCompleted (p0, p1);
	}

	private native void n_onScanCompleted (java.lang.String p0, android.net.Uri p1);

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
