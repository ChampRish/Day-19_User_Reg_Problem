﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class SpecialCharacterValidate
    {
        public string RegexPattern = "^[a-zA-Z0-9]{1,}[@_?&*;:!$]{1}[a-zA-Z0-9]{1,}$";
        public bool SpecialCharCheck(string specialvalidate)
        {
            return Regex.IsMatch(specialvalidate, RegexPattern);
        }
    }
}
