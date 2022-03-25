using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class ValidPhonNumbers
    {
        public string RegexPattern = "^[/+]91[6-9]{1}[0-9]{9}$";
        public bool PhonmumcheckCheck(string validnum)
        {
            return Regex.IsMatch(validnum, RegexPattern);
        }
    }
}
