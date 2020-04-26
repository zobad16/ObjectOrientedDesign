using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This is an adapter class that uses the IUser interface and create an adapter class through which a differnt class login can be used 
namespace BookStore.Models
{
    public class LoginAdapter : IUser
    {
        Login login;
        public LoginAdapter(Login _login)
        {
            login = _login;
        }
        public string UserName { get{ return login.UserName; } set { login.UserName = value; } }
        public string Password { get { return login.UserName; } set { login.UserName = value; } }
    }
}