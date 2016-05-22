 
        // setting layout
        Button button = FindViewById<Button>(Resource.Id.MyButton);

        WebView webv1 = FindViewById<WebView>(Resource.Id.webView1);
        webv1.Settings.JavaScriptEnabled = true;
        webv1.LoadUrl("http://news.alruabye.net/");
        webv1.Settings.LoadWithOverviewMode = true;
        webv1.SetWebViewClient(new HelloWebViewClient());
      
            webv1.GoBack();
            //webv1.GoForward();
         
  //load url inside
        public class HelloWebViewClient : WebViewClient
{
    public override bool ShouldOverrideUrlLoading(WebView view, string url)
    {
        view.LoadUrl(url);
        return true;
    }
    public override void OnPageFinished(WebView view, string url)
    {

    }
}