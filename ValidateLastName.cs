using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class ValidateLastName
    {
        public string RegexPattern = "^[A-Z]{1}[A-Z a-z]{4}$";
        public bool lastNameCheck(string lastName)
        {
            return Regex.IsMatch(lastName, RegexPattern);
        }
    }
}
