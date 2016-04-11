// On "Call" button click, try to dial phone number.
var callDialog = new AlertDialog.Builder(this);
callDialog.SetTitle("Notify");
                callDialog.SetMessage("Call me know");
                callDialog.SetNeutralButton("Call", delegate {
                 
                });
                callDialog.SetNegativeButton("Cancel", delegate { });
                callDialog.SetPositiveButton("Yes", delegate { });
                callDialog.Show();

    // this is equal
    delegate { }=(senderAlert, args) => {}

    // run on ui thread
    //run the alert in UI thread to display in the screen
RunOnUiThread (() => {
    alert.Show();
} );