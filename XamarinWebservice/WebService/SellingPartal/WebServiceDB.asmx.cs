using SellingPartal.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SellingPartal
{
    /// <summary>
    /// Summary description for WebServiceDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDB : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "Register", Description = "Register new account")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        public ReturnData Register(string UserName, string Password, string Email,
             string PhoneNumber, string Logtit, string Latitle)  /// get list of notes
        {

             int IsAdded = 1;
            string Message = "";

            // check if we have this account already
            Users myUsers = new Users();
            if (myUsers.IsAvailable(UserName, Email) == 0)
            {
                //  saving into db
                try
                {
                    using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, Email,PhoneNumber,Logtit,Latitle) VALUES (@UserName, @Password, @Email,@PhoneNumber,@Logtit,@Latitle)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        cmd.Parameters.AddWithValue("@Logtit", Logtit);
                        cmd.Parameters.AddWithValue("@Latitle", Latitle);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                    }
                    Message = "your account is created succefully";
                }
                catch (Exception ex)
                {
                    IsAdded = 0;
                    Message = ex.Message;// "Cannot add your inforamtion";
                }
            }
            else
            {
                IsAdded = 0;
                Message = "User name or email is reserved";
            }



           
            ReturnData rt = new ReturnData();
                rt.Message = Message;
            rt.UserID = IsAdded;

            return rt;
        }


        [WebMethod(MessageName = "Login", Description = "Login new user")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        public ReturnData Login(string UserName, string Password)  /// get list of notes
        {

              int UserID = 0;
            string Message = "";

            try
            {
                SqlDataReader reader;
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT UserID FROM Users where UserName=@UserName and Password=@Password ");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    connection.Open();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserID = reader.GetInt32(0);

                    }
                    if (UserID == 0)
                    {
                        Message = " user name or password is in correct";
                    }
                    reader.Close();

                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";
            }

          
            ReturnData rt = new ReturnData();
            rt.Message = Message;
            rt.UserID = UserID;

            return rt;
        }

    }
}
