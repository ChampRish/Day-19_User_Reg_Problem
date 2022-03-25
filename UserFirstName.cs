using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    internal class UserFirstName
    {
        public static string FirstName = "^[A-Z]{1}[A-Z a-z]{6}$";
        public bool Validate_First_Name(string First_Name)
        {
            return Regex.IsMatch(First_Name, FirstName);
        }
    }
}
