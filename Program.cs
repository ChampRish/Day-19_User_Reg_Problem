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
            string phone;
            bool result;
            ValidPhonNumbers validatePhoneNumber = new ValidPhonNumbers();
            Console.WriteLine("Enter PH number");
            phone = Console.ReadLine();
            result = validatePhoneNumber.PhonmumcheckCheck(phone);

            Console.WriteLine(result);
            Console.ReadLine();
            Console.ReadLine();
            }
    }
}
