// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypePattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prototype of person information
    /// </summary>
    public class PrototypePattern
    {
        /// <summary>
        /// Prototypes the pattern object.
        /// </summary>
        public static void PrototypePatternObj()
        {
            Person person = new Person();
            person.Name = "ahsan";
            person.Age = 22;
            person.Phone = 8769876578;

            Display(person);
            Person person1 = person.Clone();
            Display(person1);
            Person person2 = person.Clone();
            person2.Name = "vinayak";
            Display(person2);
        }

        /// <summary>
        /// Displays the specified person.
        /// </summary>
        /// <param name="person">The person.</param>
        public static void Display(Person person)
        {
            Console.WriteLine("Name=" + person.Name);
            Console.WriteLine("age=" + person.Age);
            Console.WriteLine("phone=" + person.Phone);
            Console.WriteLine();
        }
    }
}
