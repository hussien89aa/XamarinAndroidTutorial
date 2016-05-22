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

namespace Android_Media
{
 public  class AuthorClass
    {
        public String RealName;
        public String ServerName;
        public String StateName;
        public String ImgUrl;
        public AuthorClass() { }
        public AuthorClass(String ServerName, String RealName)
        {
            this.ServerName = ServerName;
            this.RealName = RealName;
        }
        public AuthorClass(String ServerName, String RealName, String StateName, String ImgUrl)
        {
            this.ServerName = ServerName;
            this.RealName = RealName;
            this.StateName = StateName;
            this.ImgUrl = ImgUrl;
        }
    }
 
}