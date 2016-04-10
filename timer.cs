 System.Timers.Timer t;
 
   t = new System.Timers.Timer();
                t.Interval = 3000;
                t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
                t.Start();

        protected void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            t.Stop();
            TextView v = (TextView)FindViewById(Resource.Id.textView1);
            v.Text = "ege";
        }