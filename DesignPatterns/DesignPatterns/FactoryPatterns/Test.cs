// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// test class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Computers the factory object.
        /// </summary>
        public static void TestObj()
        {
            Computer pc = ComputerFactory.GetString("pc", "10gb", "20gb");
            Computer server = ComputerFactory.GetString("server", "20gb", "30gb");
            Console.WriteLine("factory pc:" + pc);
            Console.WriteLine("factory server:" + server);
        }
    }
}
