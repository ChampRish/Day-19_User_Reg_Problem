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
            string Email;
            bool result;
            EmailValidation validateemail = new EmailValidation();
            Console.WriteLine("Enter Email: ");
            Email = Console.ReadLine();
            result = validateemail.emailCheck(Email);
            Console.WriteLine(result);
            Console.ReadLine();
            }
    }
}
