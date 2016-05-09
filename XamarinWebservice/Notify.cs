
[WebMethod(MessageName = "LoginNotify", Description = "Login Notify new user")]

[System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
public ReturnData LoginNotify(int UserID)  /// get list of notes
{

    string Message = "";

    try
    {
        SqlDataReader reader;
        using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("SELECT UserName,UserID FROM Users where UserID>@UserID and UserID=(SELECT MAX(UserID) FROM[Users])");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@UserID", UserID);
            connection.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Message = reader.GetString(0);
                UserID = reader.GetInt32(1);
            }
            if (Message.Length == 0)
            {
                UserID = 0;
                Message = "NO NEW USER";
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