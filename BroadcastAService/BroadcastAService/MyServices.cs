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
using System.Threading.Tasks;
using System.Threading;

namespace BroadcastAService
{
    [Service]
    class MyServices : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
         
        }
        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {

            // countine
            new Task(() =>
            {
               while(true)
                {
                    Thread.Sleep(10000);
                    Intent intents = new Intent();
                    intents.SetAction("com.alr.text");
                    intents.PutExtra("MyData", "Data from service");
                    SendBroadcast(intents);

               
                }

            }).Start();

            return StartCommandResult.Sticky;
        }

   
    }
}