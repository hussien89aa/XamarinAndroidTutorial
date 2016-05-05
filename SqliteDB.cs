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
using SQLite;
using System.IO;
 


namespace AndroidSQLite
{
    class SqliteDB
    {
        //database path
        string dbPath = Path.Combine(
 System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
          "Departments.db3");

        public SqliteDB()
        {
            //Creating database, if it doesn't already exist 
            if (!File.Exists(dbPath))
            {  
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<Departments>();
             }
            //if (db.Table<Departments>().Count() == 0)
        }

        public void Insert(string FullNamee)
          {
                 var db = new SQLiteConnection(dbPath);
                 var newDepartments = new Departments();
                 newDepartments.FullName = FullNamee;
                 db.Insert(newDepartments);
            }
        public void update(string FullNamee,int id)
        {
            var db = new SQLiteConnection(dbPath);
            var newDepartments = new Departments();
            newDepartments.FullName = FullNamee;
            newDepartments.Id = id;
            db.Update(newDepartments);
        }
        public void delete( int id)
        {
            var db = new SQLiteConnection(dbPath);
            var newDepartments = new Departments();
            newDepartments.Id = id;
            db.Delete(newDepartments);
           // db.Execute(""); 
        }

        public string select(string FullName)
        {
            string data = "";
            var db = new SQLiteConnection(dbPath);
           
            var DepartmentssStartingWithA = db.Query<Departments>("SELECT * FROM Departments WHERE FullName = ?", FullName);
            foreach (var s in DepartmentssStartingWithA)
            {
                data += s.Id + " " + s.FullName + "\n";
            }
            return data;
        }
     
           public string SelectAll()
        {
            string data = "";
            var db = new SQLiteConnection(dbPath);
            Console.WriteLine("Reading data From Table");
            var table = db.Table<Departments>();
            foreach (var s in table)
            {
                data+=s.Id + " " + s.FullName +"\n" ;
            }
            return data;
        }

        [Table("Departments")]
        public class Departments
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }
            [MaxLength(8)]
            public string FullName { get; set; }
        }

    }


}