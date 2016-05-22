using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;
using System.Collections.Generic;

namespace Android_Media
{ //MainLauncher = true, 
    [Activity(Label = "Android_Media",  Icon = "@drawable/icon")]
    public class AyA : Activity
    {
        List<AuthorClass> tableItems = new List<AuthorClass>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Recities);
            //set timer 
            LnaguageClass recitesn = new LnaguageClass();
            tableItems = recitesn.GuranAya(Intent.GetStringExtra("Recites"));
            ListView listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new HomeScreenAdapter(this, tableItems);
            listView.ItemClick += OnListItemClick;  // to be defined
        }
        // get item slected
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("URLAya", t.ImgUrl);
            StartActivity(intent);
        }
        public class HomeScreenAdapter : BaseAdapter<AuthorClass>
        {
            List<AuthorClass> items;
            Activity context;
            public HomeScreenAdapter(Activity context, List<AuthorClass> items)
                : base()
            {
                this.context = context;
                this.items = items;
            }
            public override long GetItemId(int position)
            {
                return position;
            }
            public override AuthorClass this[int position]
            {
                get { return items[position]; }
            }
            public override int Count
            {
                get { return items.Count; }
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = items[position];
                View view = convertView;
                if (view == null) // no view to re-use, create new
                    view = context.LayoutInflater.Inflate(Resource.Layout.CustomView, null);
                view.FindViewById<TextView>(Resource.Id.Text1).Text = item.RealName;
                view.FindViewById<TextView>(Resource.Id.Text2).Text = item.ServerName;
             //   view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.ImageResourceId);
                return view;
            }
        }

    }
}

