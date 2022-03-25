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
            string Pass;
            bool result;
            UpperCaseValidate uppercasevalidate = new UpperCaseValidate();
            Console.WriteLine("Enter Password: ");
            Pass = Console.ReadLine();
            result = uppercasevalidate.UpperCaseCheck(Pass);
            Console.WriteLine(result); ;
            Console.ReadLine();
            }
    }
}
