using System.Text.RegularExpressions;

namespace TDDAuthenticationSprint
{
    public class Validator
    {


        public static string userPattern = @"^[a-zA-Z]+$";
        public static string PasswordPattern = "^[0-9]+$";

        public bool IsValidUser(string username)
        {
            //    if ((!string.IsNullOrEmpty(username)) && username.Length > 1 && username.Length < 11 && Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            return (!string.IsNullOrEmpty(username)) && Regex.IsMatch(username, userPattern);
            
        }

        public bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, PasswordPattern) ? true : false;
        }

    }

}   