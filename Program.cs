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
            string Numeric;
            bool result;
            NumericNumberValidate numbervalidate = new NumericNumberValidate();
            Console.WriteLine("Enter Password: ");
            Numeric = Console.ReadLine();
            result = numbervalidate.numericCheck(Numeric);
            Console.WriteLine(result);

            Console.ReadLine();
            }
    }
}
