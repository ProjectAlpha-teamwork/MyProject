using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Validation
    {
        public const string EmailPattern =
         @"^([0-9a-zA-Z]" +
         @"([\+\-_\.][0-9a-zA-Z]+)*" +
         @")+" +
         @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

        public const string UserNamePattern = @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$";

        public const string NamePattern = @"[a-zA-Z]";

        public const string SsnPattern = @"[0-9]";

        public const decimal MaxDeposit = 100000;

        public const string PassPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$";

        public const int DaysInYear = 365;

        public const int MinYearsForRegistration = 18;

        public static bool IsValid(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

    }
}
