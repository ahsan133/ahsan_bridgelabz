// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;   
    using System.Text;   
    using Newtonsoft.Json;
    
    /// <summary>
    /// Reading data from json 
    /// </summary>
    public class DataManagement
    {
        /// <summary>
        /// Dates the management object.
        /// </summary>
        public static void DataManagementObj()
        {
            ////reading the json file
            StreamReader file = new StreamReader(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\inventory.json");
            var json = file.ReadToEnd();
            ////Converting json to .net type
            var files = JsonConvert.DeserializeObject<List<Inventory>>(json);
            
            foreach (var item in files)
            {
                Console.WriteLine("name = " + item.Name + "\nweight = " + item.Weight + "\nprice per kg =" + item.Price + "\nTotal amount = " + (item.Weight * item.Price));
                Console.WriteLine();
            }
        }
    }
}
