void SaveData(int Rating)
{
    ISharedPreferences prefe = PreferenceManager.GetDefaultSharedPreferences(this)
        ;
    ISharedPreferencesEditor editor = prefe.Edit();
    editor.PutInt("Rate", Rating);
    editor.PutString("userName", "hussien89aa");
    editor.Apply();
}

void CheckData()
{
    ISharedPreferences prefe = PreferenceManager.GetDefaultSharedPreferences(this);
    int Rate = prefe.GetInt("Rate", 0);
    string username = prefe.GetString("userName", "no name");

}