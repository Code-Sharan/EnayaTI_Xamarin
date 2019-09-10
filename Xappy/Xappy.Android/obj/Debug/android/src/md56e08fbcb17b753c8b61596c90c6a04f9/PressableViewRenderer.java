package md56e08fbcb17b753c8b61596c90c6a04f9;


public class PressableViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.VisualElementRenderer_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xappy.Droid.Renderers.PressableViewRenderer, Xappy.Android", PressableViewRenderer.class, __md_methods);
	}


	public PressableViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PressableViewRenderer.class)
			mono.android.TypeManager.Activate ("Xappy.Droid.Renderers.PressableViewRenderer, Xappy.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public PressableViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PressableViewRenderer.class)
			mono.android.TypeManager.Activate ("Xappy.Droid.Renderers.PressableViewRenderer, Xappy.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public PressableViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PressableViewRenderer.class)
			mono.android.TypeManager.Activate ("Xappy.Droid.Renderers.PressableViewRenderer, Xappy.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
