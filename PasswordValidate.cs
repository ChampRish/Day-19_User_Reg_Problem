using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class PasswordValidate
    {
        public string RegexPattern = "^[a-zA-Z0-9]{8,}$";
        public bool passwordCheck(string password)
        {
            return Regex.IsMatch(password, RegexPattern);
        }
    }
}
