package md5cf8074e787038f65a7c4b5b64bfd69d7;


public class MyServices
	extends mono.android.app.IntentService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onHandleIntent:(Landroid/content/Intent;)V:GetOnHandleIntent_Landroid_content_Intent_Handler\n" +
			"n_onStartCommand:(Landroid/content/Intent;II)I:GetOnStartCommand_Landroid_content_Intent_IIHandler\n" +
			"";
		mono.android.Runtime.register ("BroadcastAService.MyServices, BroadcastAService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyServices.class, __md_methods);
	}


	public MyServices (java.lang.String p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MyServices.class)
			mono.android.TypeManager.Activate ("BroadcastAService.MyServices, BroadcastAService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public MyServices () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyServices.class)
			mono.android.TypeManager.Activate ("BroadcastAService.MyServices, BroadcastAService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onHandleIntent (android.content.Intent p0)
	{
		n_onHandleIntent (p0);
	}

	private native void n_onHandleIntent (android.content.Intent p0);


	public int onStartCommand (android.content.Intent p0, int p1, int p2)
	{
		return n_onStartCommand (p0, p1, p2);
	}

	private native int n_onStartCommand (android.content.Intent p0, int p1, int p2);

	java.util.ArrayList refList;
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
