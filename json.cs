     //  1-- add json.net componenet

//2read and display json data
var textView1 = FindViewById<TextView>(Resource.Id.textView1);

string json = "{name:'hussein alrubaye',jobs:['developer','tester','admin'],age:27 }";

var mydata = JObject.Parse(json);

string name = mydata["name"].ToString();
var jobs = mydata["jobs"];
string Firstjob = jobs[0].ToString();
int age = Convert.ToInt32(mydata["age"].ToString());
textView1.Text = "name:" + name + ",first job:" + Firstjob + ", his age:" + age;