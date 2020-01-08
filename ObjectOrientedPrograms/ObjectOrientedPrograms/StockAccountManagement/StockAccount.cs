// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.StockAccountManagement
{ 
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Main Class
    /// </summary>
    public class StockAccount
    {
        /// <summary>
        /// Stocks the account object.
        /// </summary>
        public static void StockAccountObj()
        {
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<StockManagement>>(json);
            foreach (var i in array)
            {
                Console.WriteLine("name= " + i.Name);
                Console.WriteLine("number of shares= " + i.Shares);
                Console.WriteLine("share price= " + i.SharePrice);
                Console.WriteLine("value of each stock= " + (i.SharePrice / 12));
                Console.WriteLine("Total value= " + (i.SharePrice * i.Shares) + "\n");
            }
        }
    }
}