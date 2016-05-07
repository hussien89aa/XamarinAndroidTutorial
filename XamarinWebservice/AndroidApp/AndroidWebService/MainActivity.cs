using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
 
namespace AndroidWebService
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
         
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button bulogin = FindViewById<Button>(Resource.Id.bulogin);
            Button buRegister = FindViewById<Button>(Resource.Id.buRegister);
           
            buRegister.Click += BuRegister_Click;
            bulogin.Click += Bulogin_Click;

        }

        private void Bulogin_Click(object sender, EventArgs e)
        {
            var etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            var etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            selling.WebServiceDB ws = new selling.WebServiceDB();
            ws.LoginCompleted += Ws_LoginCompleted;
            ws.LoginAsync(etUsername.Text, etPassword.Text);
        }

        private void Ws_LoginCompleted(object sender, selling.LoginCompletedEventArgs e)
        {
            string msg = "";
         if (e.Result.UserID.ToString().Equals("0"))
            {
                msg = e.Result.Message;

            }
            else
            {
                msg = "You login with id:" + e.Result.UserID;
            }
            var callDialog = new AlertDialog.Builder(this);
            callDialog.SetTitle("Notify");
            callDialog.SetMessage(msg);
            callDialog.SetNeutralButton("Ok", delegate {

            });
            callDialog.Show();
        }

        //open regiser page
        private void BuRegister_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Register));
        }

        //private  void Button_Click(object sender, EventArgs e)
        //{
        //    findphone.WebService2 s = new findphone.WebService2();
        //    s.OpenAccountAsync("ahmed", "123",true, "a@yahoo.com");
        //    s.OpenAccountCompleted += S_OpenAccountCompleted;

        //}

        //private void S_OpenAccountCompleted(object sender, OpenAccountCompletedEventArgs e)
        //{
        //    string s = e.Result.AdminID.ToString();
        //}



        //WebService2SoapClient wsc = new WebService2SoapClient();
        //IsExisitAccountResponse ret = await wsc.IsExisitAccountAsync(txtuser.Text, txtPassword.Password);

        //    if (ret.Body.IsExisitAccountResult.ErrorID == 2)
        //    {
        //        GlobaVar.AdminID = ret.Body.IsExisitAccountResult.AdminID;

        //        this.Frame.Navigate(typeof(ControlForm));
        //    }
    }
}

