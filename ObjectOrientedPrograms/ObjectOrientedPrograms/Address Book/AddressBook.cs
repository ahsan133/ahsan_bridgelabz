using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.Address_Book
{
    public class AddressBook
    {
        public static void AddressBookObj()
        {
           // string files = File.ReadAllText(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Address Book\Addressjson.json");
            //AddressMaintain array = JsonConvert.DeserializeObject<AddressMaintain>(files);

            //foreach (var i in array)
             //   Console.WriteLine(i.FirstName);

            StreamReader file = new StreamReader(@"C:\Users\Admin\source\ahsan\ObjectOrientedPrograms\ObjectOrientedPrograms\Address Book\Addressjson.json");
            var json = file.ReadToEnd();
            var array = JsonConvert.DeserializeObject<List<AddressMaintain>>(json);

            foreach(var i in array)
            Console.WriteLine(i.FirstName);


            //Operations.Remove();
            //Operations.Insert();
            Operations.Update();
        }
    }
}