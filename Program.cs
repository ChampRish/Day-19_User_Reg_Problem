﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_User_Reg_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string FirstName;
                bool result;
                UserFirstName Check = new UserFirstName();

                Console.WriteLine(" Enter First Name :");
                FirstName = Console.ReadLine();

                result = Check.Validate_First_Name(FirstName);
                Console.WriteLine(result);

            if (FirstName.Length < 3)
            {
                Console.WriteLine("Enter minimum of 3 characters");
            }
            Console.ReadLine();
            }
    }
}
