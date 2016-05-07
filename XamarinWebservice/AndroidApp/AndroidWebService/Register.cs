using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidWebService
{
    [Activity(Label = "Register", Icon = "@drawable/icon")]

    class Register :Activity
    {
       

            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);

                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Register);

                // Get our button from the layout resource,
                // and attach an event to it
                Button buRegister = FindViewById<Button>(Resource.Id.buRegister);
               

            buRegister.Click += BuRegister_Click;
            }

        private void BuRegister_Click(object sender, EventArgs e)
        {
            var etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            var etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            var etEmail = FindViewById<EditText>(Resource.Id.etEmail);
            var etPhoneNumber = FindViewById<EditText>(Resource.Id.etPhoneNumber);
            selling.WebServiceDB ws = new selling.WebServiceDB();
            ws.RegisterCompleted += Ws_RegisterCompleted;
            ws.RegisterAsync(etUsername.Text, etPassword.Text, etEmail.Text, etPhoneNumber.Text, "22", "33");
        }

        private void Ws_RegisterCompleted(object sender, selling.RegisterCompletedEventArgs e)
        {
               
                var callDialog = new AlertDialog.Builder(this);
            callDialog.SetTitle("Notify");
            callDialog.SetMessage(e.Result.Message);
            callDialog.SetNeutralButton("Ok", delegate {

            });
             callDialog.Show();
        }
    }
}