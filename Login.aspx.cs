using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomUser;
namespace LogIn
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string test(string username,string password) {
            //string user,string password
            User attempt = new User(username, password);
            Dictionary<string, string> data = fetchUsers("database.txt");
            //string result = "Checking if Username [" + attempt.getUsername() + "] is in Database: " + data.ContainsValue(attempt.getUsername()) + "\n Comparing password [" + attempt.getPassword() + "] ==" + data[attempt.getUsername()];
            if (attempt.getPassword() == data[attempt.getUsername()] )
            {
                return "pass";
            }
            else {
                return  "fail";
            }
            
        }
        public static Dictionary<string, string> fetchUsers(string filename)
        {
            //TODO figure out better implementation
            //Update Users
            Dictionary<string, string> database = new Dictionary<string, string>();
            string path = "C:\\Users\\ftommasi\\Documents\\Visual Studio 2015\\Projects\\WebSite1\\LogIn\\" + filename;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                //TODO verify functionlaity of split
                string[] linesplit = line.Split(null);

                System.Console.WriteLine(linesplit.ToString());

                string tempname = linesplit[0];
                string temppass = linesplit[1];

                User tempuser = new User(tempname, temppass);
                //Only add new users            
                if (!database.ContainsKey(tempuser.getUsername()))
                {
                    database.Add(tempuser.getUsername(), temppass);
                }
            }

            return database;

        }


        
        public static string processRequest()
        {
            return "successfully linked C# and angular";
            /*
           string uname="";
           string pass="";
           User temp = new User(uname, pass);
           string response = (this.database.ContainsKey(temp)) ? response = "{\"status\":" + "\"" + temp.authenticate(pass) + "\"" : response = "{\"status\":" + "\"FAILED\""; ;
           */

        }

    }


}