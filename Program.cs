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
            string Name;
            bool result;
            ValidateLastName validatelastname = new ValidateLastName();
            Console.WriteLine("Enter Last Name: ");
            Name = Console.ReadLine();
            result = validatelastname.lastNameCheck(Name);
            Console.WriteLine(result);

            if (Name.Length < 3)
            {
                Console.WriteLine("Enter minimum of 3 characters");
            }
            Console.ReadLine();
            }
    }
}
