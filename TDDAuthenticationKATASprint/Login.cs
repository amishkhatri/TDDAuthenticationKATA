using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TDDAuthenticationSprint;

namespace TDDAuthenticationSprint
{
    public class Login
    {
        User CreateAccount;

        public void CreateUser(User createAccount)
        {
            this.CreateAccount = createAccount;
        }

        public string UserLogin(string username, string password)
        {

            //string outpassword;
            //if ( CreateAccount.GetUser.TryGetValue(username,out outpassword) )
            //      return String.Equals(CreateAccount.GetUser[username].ToString(), password) ? "User Logged In Successfully" : "Login failed.Invalid password";
            //else
            //     return "Login failed.Invalid username";

            if (CreateAccount.GetUser.ContainsKey(username))
                return String.Equals(CreateAccount.GetUser[username].ToString(), password) ? "User Logged In Successfully" : "Login failed.Invalid password";
            else
                return "Login failed.Invalid username";
        }    
    }

}