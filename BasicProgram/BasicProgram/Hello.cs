// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hello.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class Hello
    {
        public static void hello()
        {
        Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            if (name.Length<3)
                Console.WriteLine("name should not be less than 3 characters");
            else
            Console.WriteLine("Hello "+name);
        }

    }
}
