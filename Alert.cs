// On "Call" button click, try to dial phone number.
    var callDialog = new AlertDialog.Builder(this);
    callDialog.SetMessage("Call " + translatedNumber + "?");
    callDialog.SetNeutralButton("Call", delegate {
           // Create intent to dial phone
           var callIntent = new Intent(Intent.ActionCall);
           callIntent.SetData(Android.Net.Uri.Parse("tel:" + translatedNumber));
           StartActivity(callIntent);
       });
    callDialog.SetNegativeButton("Cancel", delegate { });
alert.SetPositiveButton ("Yes",delegate { }  );
     callDialog.Show();


    // this is equal
    delegate { }=(senderAlert, args) => {}

    // run on ui thread
    //run the alert in UI thread to display in the screen
RunOnUiThread (() => {
    alert.Show();
} );