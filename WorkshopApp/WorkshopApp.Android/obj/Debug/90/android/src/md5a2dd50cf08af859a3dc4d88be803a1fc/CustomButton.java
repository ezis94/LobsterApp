package md5a2dd50cf08af859a3dc4d88be803a1fc;


public class CustomButton
	extends md5a6256f8d5bc17d3565a450e514d4a6e7.MaterialButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("WorkshopApp.CustomRenderers.CustomButton, WorkshopApp.Android", CustomButton.class, __md_methods);
	}


	public CustomButton (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("WorkshopApp.CustomRenderers.CustomButton, WorkshopApp.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CustomButton (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("WorkshopApp.CustomRenderers.CustomButton, WorkshopApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomButton (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("WorkshopApp.CustomRenderers.CustomButton, WorkshopApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
