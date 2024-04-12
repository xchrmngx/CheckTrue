using System.Text.RegularExpressions;

namespace CheckTrue
{
    public class CheckTrue
    {
        public static bool Check_Mail(string Mail)
        {
            bool IsTrue = false;
            string pattern = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (Regex.IsMatch(Mail, pattern, RegexOptions.IgnoreCase))
                IsTrue = true;
            return IsTrue;
        }

        public static bool Check_Password(string Password)
        {
            bool IsTrue = false;
            string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{1,16}$";

            if (Regex.IsMatch(Password, Pattern, RegexOptions.IgnoreCase))
                IsTrue = true;
            return IsTrue;
        }

        public static bool Check_Login(string Login)
        {
            bool IsTrue = false;
            string Pattern = @"^[a-zA-Z0-9]{6,}$";

            if (Regex.IsMatch(Login, Pattern, RegexOptions.IgnoreCase))
                IsTrue = true;
            return IsTrue;
        }
    }
}