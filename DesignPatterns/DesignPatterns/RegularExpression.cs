// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Regular expression program
    /// </summary>
    public class RegularExpression
    {
        /// <summary>
        /// Regulars the expression object.
        /// </summary>
        public static void RegularExpressionObj()
        {
            string expression = "Hello <<name>> ," +
                "we have your full name as <<fullname>> in our system." +
                " your contact number is 91-xxxxxxxxxx. Please," +
                "let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            Console.WriteLine("Enter your full name");
            string fullname = Console.ReadLine();
            string name = @"^[a-zA-Z]";
            Regex regex = new Regex(name);
            ////Checking if the name id string or not
            if (!regex.IsMatch(fullname))
            {
                Console.WriteLine("enter proper name");
                return;
            }
            
            string[] split = fullname.Split(" ");
            Console.WriteLine("enter mobile number");
            double phone = Convert.ToDouble(Console.ReadLine());
            string number = @"^[0-9]{10}";
            Regex regex1 = new Regex(number);
            ////Checking if the mobile number is a double value or not
            if (!regex1.IsMatch(phone.ToString()))
            {
                Console.WriteLine("enter proper mobile number");
            }

            string date = DateTime.Today.ToString();
            string result = expression.Replace("<<name>>", split[0]).Replace("<<fullname>>", fullname).Replace("xxxxxxxxxx", phone.ToString()).Replace("01/01/2016", date);
            Console.WriteLine(result);
        }
    }
}