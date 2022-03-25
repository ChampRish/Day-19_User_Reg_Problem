using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string SpecialChar;
            bool result;
            SpecialCharacterValidate specialCharvalidate = new SpecialCharacterValidate();
            Console.WriteLine("Enter Your Password: ");
            SpecialChar = Console.ReadLine();
            result = specialCharvalidate.SpecialCharCheck(SpecialChar);
            Console.WriteLine(result);

            Console.ReadLine();
            }
    }
}
