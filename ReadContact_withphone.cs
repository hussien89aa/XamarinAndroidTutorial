using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;
using Android.Database;
using System.Collections.Generic;

namespace ReadContact
{
    [Activity(Label = "ReadContact", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TextView textView1;
        Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
             button = FindViewById<Button>(Resource.Id.MyButton);
             textView1 = FindViewById<TextView>(Resource.Id.textView1);

            button.Click += delegate {

                FillContacts();

            };
        }

        void FillContacts()
        {
            var uri = ContactsContract.CommonDataKinds.Phone.ContentUri;  
            string[] projection = {
       ContactsContract.CommonDataKinds.Phone.Number,
       ContactsContract.Contacts.InterfaceConsts.DisplayName,
       ContactsContract.Contacts.InterfaceConsts.PhotoId
  };
            //select id,DisplayName,PhotoId where id=1
            var loader = new CursorLoader(this, uri, projection, null, null, null);
            var cursor = (ICursor)loader.LoadInBackground();
            List<Contact> contactList = new List<Contact>();
            if (cursor.MoveToFirst())
            {
                do
                {
                    contactList.Add(
                    new Contact(cursor.GetString(cursor.GetColumnIndex(projection[0])),
                         cursor.GetString(cursor.GetColumnIndex(projection[1])),
                       cursor.GetString(cursor.GetColumnIndex(projection[2]))
                   )
                   );
                } while (cursor.MoveToNext());
            }
            string items = "";
            foreach ( Contact c in contactList)
            {
                items += c.DisplayName + "," + c.Number + "," + c.PhotoId;
            }
            textView1.Text = items;
        }
        class Contact
        {
           public string Number;
            public string DisplayName;
            public string PhotoId;
            public Contact(string Number, string DisplayName, string PhotoId)
            {
                this.Number = Number;
                this.DisplayName = DisplayName;
                this.PhotoId = PhotoId;
            }
        }
    }
}

