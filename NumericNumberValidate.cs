using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class NumericNumberValidate
    {
        public string RegexPattern = "^[a-zA-Z0-9]{7,}[0-9]{1}$";
        public bool numericCheck(string numericNumber)
        {
            return Regex.IsMatch(numericNumber, RegexPattern);
        }
    }
}
