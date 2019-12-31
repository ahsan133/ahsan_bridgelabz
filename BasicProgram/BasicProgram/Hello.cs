// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hello.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace BasicProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BasicPrograms;

    /// <summary>
    /// Replace the word in a string
    /// </summary>
    public class Hello
    {
        /// <summary>
        /// Hellos the object.
        /// </summary>
        public static void HelloObj()
        {
        Console.WriteLine("enter your name");
            string str = "Hello <<name>>";
            string name = Utility.IsString(Console.ReadLine());
            if (name.Length < 3)
            {
                Console.WriteLine("name should not be less than 3 characters");
            }
            else
            {
                string s = str.Replace("<<name>>", name);
                Console.WriteLine(s);
            }
        }
    }
}
