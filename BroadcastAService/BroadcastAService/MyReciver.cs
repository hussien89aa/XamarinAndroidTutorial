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
using Android.Telephony;
using Android.Provider;
using Xamarin.Controls;

namespace BroadcastAService
{
 
  [BroadcastReceiver(Exported = true, Label = "SMS Receiver")]
    [IntentFilter(new string[] { "android.provider.Telephony.SMS_RECEIVED", "com.alr.text" })]
    public class MyReciver : Android.Content.BroadcastReceiver
    {
        private const string Tag = "SMSBroadcastReceiver";
        private const string IntentAction = "android.provider.Telephony.SMS_RECEIVED";

        public override void OnReceive(Context context, Intent intent)
        {
            // Log.Info(Tag, "Intent received: " + intent.Action);
            // read the SendBroadcast data
            if (intent.Action == "com.alr.text")
            {
                string text = intent.GetStringExtra("MyData") ?? "Data not available";
                Toast.MakeText(context, text, ToastLength.Short).Show();
                Intent intents = new Intent(context, typeof(MainActivity));
                intents.AddFlags(ActivityFlags.NewTask);
                context.StartActivity(intents);
            }
            //read incomming sms
            if (intent.Action == IntentAction)
            {

                SmsMessage[] messages = Telephony.Sms.Intents.GetMessagesFromIntent(intent);

                var sb = new StringBuilder();

                for (var i = 0; i < messages.Length; i++)
                {

                    sb.Append(string.Format("SMS From: {0}{1}Body: {2}{1}", messages[i].OriginatingAddress,
                        System.Environment.NewLine, messages[i].MessageBody));
                }
                Toast.MakeText(context, sb.ToString(), ToastLength.Short).Show();
            }
        }
    }
}