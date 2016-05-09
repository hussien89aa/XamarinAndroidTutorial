package md542e23b173f77c31075119ae748ad8ad1;


public class CloseTask
	extends java.util.TimerTask
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Controls.CloseTask, AlertCenter.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", CloseTask.class, __md_methods);
	}


	public CloseTask () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CloseTask.class)
			mono.android.TypeManager.Activate ("Xamarin.Controls.CloseTask, AlertCenter.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
