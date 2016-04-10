
//task
var t = Task.Factory.StartNew(() => DoAction());



// Thread
//1- Check with Thread and without Thread
ThreadPool.QueueUserWorkItem (o => SlowMethod ());
 
 

    private void SlowMethod ()
    {
        Thread.Sleep (5000);
        RunOnUiThread (() => textview.Text = "Method Complete");
    }



    //URL
    //https://developer.xamarin.com/guides/android/advanced_topics/writing_responsive_applications/