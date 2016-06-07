using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomUser;
using LogIn;
namespace Test
{
    public class UserTest
    {
        public static void Main(string[] args)
        {
            LogIn.Login testLogin = new LogIn.Login();
            LogIn.Login.fetchUsers("database.txt");
        }
    }
}