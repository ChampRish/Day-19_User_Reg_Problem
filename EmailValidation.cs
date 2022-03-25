using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class EmailValidation
    {
        public string RegexPattern = "^[a-zA-Z]+[.]{0,1}[a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public bool emailCheck(string email)
        {
            return Regex.IsMatch(email, RegexPattern);
        }
    }
}
