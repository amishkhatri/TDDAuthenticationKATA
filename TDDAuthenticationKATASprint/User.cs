using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace TDDAuthenticationSprint
{
    public class User
    {
        public Dictionary<string, string> Users = new Dictionary<string, string>();
        public Dictionary<string, string> GetUser
        {
            get { return Users; }
            set { Users = value; }
        }

        public bool IsValidUser(string username)
        {
            return ((!string.IsNullOrEmpty(username)) && ( username.Length > 1 && username.Length < 11 ) && Regex.IsMatch(username, @"^[a-zA-Z]+$"));
        }

        public bool IsValidPassword(string password)
        {
            return (password.Length >= 8 && Regex.Match(password, @"^.*(?=.*[0-9]{2})(?=.*[a-zA-Z]{2}).*$").Success);
        }

        public string createUser(string username, string password)
        {
            if (IsValidUser(username) && IsValidPassword(password))
            {
                Users.Add(username, password);
                return "User Created Successfully";
            }
            else
                return "User Creation Failed";
            
        }

    }
}
