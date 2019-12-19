// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hello.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using BasicPrograms;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class Hello
    {
        public static void HelloObj()
        {
        Console.WriteLine("enter your name");
            string str = "Hello <<name>>";
            string name = Utility.IsString(Console.ReadLine());
            if (name.Length < 3)
                Console.WriteLine("name should not be less than 3 characters");
            else
            {
                string s = str.Replace("<<name>>", name);
                Console.WriteLine(s);
            }
        }
    }
}
