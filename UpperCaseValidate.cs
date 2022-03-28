using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    internal class UpperCaseValidate
    {
        public string RegexPattern = "^[A-Z]{1}[a-zA-Z0-9]{7,}$";
        public bool UpperCaseCheck(string UCase)
        {
            return Regex.IsMatch(UCase, RegexPattern);
        }
    }
}
