using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace Android_Media
{ //MainLauncher = true, 
    [Activity(Label = "Android_Media",   Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        System.Timers.Timer t;
        SeekBar seekBar1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //set timer 
            t = new System.Timers.Timer();
            t.Interval = 3000;
            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            seekBar1 = FindViewById<SeekBar>(Resource.Id.seekBar1);

            //prepar audio
            string filePath = Intent.GetStringExtra("URLAya");
            PreparePlayer(filePath);

            //start
            Button button = FindViewById<Button>(Resource.Id.bustart);
            button.Click += delegate {
                player.Start();
                t.Start();
            };
            //stop
            Button buStop = FindViewById<Button>(Resource.Id.buStop);
            buStop.Click += delegate {
                player.Stop();
                t.Stop();
                PreparePlayer(filePath);
            };
            //pause
            Button buPause = FindViewById<Button>(Resource.Id.buPause);
            buPause.Click += delegate {
                player.Pause();
                t.Stop();
            };
        }

        protected MediaPlayer player;
        public void PreparePlayer(String filePath)
        {
            if (player == null)
            {
                player = new MediaPlayer();
            }
            player.Reset();
            player.SetDataSource(filePath);
            player.Prepare();
            seekBar1.Max = player.Duration;


        }
        protected void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            seekBar1.Progress = player.CurrentPosition;
        }
    }
}

