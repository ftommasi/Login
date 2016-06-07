using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// User for Login page
/// </summary>
/// 
namespace CustomUser
{
    public class User
    {
        public string password;
        public string username;
        public User(string uname, string pwd)
        {
            username = uname;
            password = pwd;


        }

        public bool authenticate(string attempt)
        {

            if (attempt == password)
                return true;
            else
                return false;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string newpass)
        {
            //TODO add password constraints
            password = newpass;
        }


        override public string ToString()
        {
            return username;
        }


    }
}