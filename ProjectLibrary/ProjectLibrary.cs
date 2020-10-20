using System;
using System.Text.RegularExpressions;

namespace ProjectLibrary
{
    public class RegexLibrary
    {

        public static bool IsValidName(string name)
        {
            Regex rx = new Regex(@"^[A-Z][a-z]{1,30}");

            return rx.IsMatch(name);
        }

        public static bool IsValidEmail(string name)
        {
            Regex rx = new Regex(@"(.+)@(.+){2,}\.(.+){2,}");

            return rx.IsMatch(name);
        }

        public static bool IsValidPhoneNumber(string name)
        {
            Regex rx = new Regex(@"^\d{3}-\d{3}-\d{4}");

            return rx.IsMatch(name);
        }

        public static bool IsValidDate(string name)
        {
            Regex rx = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$");

            return rx.IsMatch(name);
        }
    }
}
