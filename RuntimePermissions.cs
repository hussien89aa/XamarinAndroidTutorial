 // add  send sms in maifest


namespace AndroidPermissions
{
    [Activity(Label = "AndroidPermissions", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
     

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async delegate {

                await TryGetSendSMSAsync() ;
              
            };
        }

        
 
      async Task TryGetSendSMSAsync()
        {
            if ((int)Build.VERSION.SdkInt < 23)
            {
                await SMSSend();
                return;
            }

            await GetSendSMSPermissionAsync();
        }
        async Task GetSendSMSPermissionAsync()
        {
            //Check to see if any permission in our group is available, if one, then all are
            const string permission = Manifest.Permission.SendSms;
            if (CheckSelfPermission(Manifest.Permission.SendSms) == (int)Permission.Granted)
            {
                await SMSSend();
                return;
            }

            //need to request permission
            if (ShouldShowRequestPermissionRationale(permission))
            {
               
                var callDialog = new AlertDialog.Builder(this);
                callDialog.SetTitle("explain");
                callDialog.SetMessage("This app needt to send sms so it need sms send permission");
                callDialog.SetNeutralButton("yes", delegate {
                   RequestPermissions(PermissionsLocation, RequestLocationId);
                });
                callDialog.SetNegativeButton("no", delegate { });
               
                callDialog.Show();
                return;
            }
            //Finally request permissions with the list of permissions and Id
            RequestPermissions(PermissionsLocation, RequestLocationId);
        }
    readonly string[] PermissionsLocation =
     {
      Manifest.Permission.SendSms //, more
     };

        const int RequestLocationId = 0;
        public override async void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            switch (requestCode)
            {
                case RequestLocationId:
                    {
                        if (grantResults[0] == Permission.Granted)
                        {
                            //Permission granted
                        
                            Toast.MakeText(this, "sms send permission is available", ToastLength.Long).Show();
                            await SMSSend();
                        }
                        else
                        {
                            //Permission Denied :(
                            //Disabling location functionality
                            Toast.MakeText(this, "sms send permission is denailed", ToastLength.Long).Show();
                            ;
                        }
                    }
                    break;
            }
        }
        async Task SMSSend()
        {
             try
            {
                SmsManager.Default.SendTextMessage("1234567890", null, "Hello from Xamarin.Android", null, null);
            }
            catch (Exception ex)
            {
             }
        }
    }
}

