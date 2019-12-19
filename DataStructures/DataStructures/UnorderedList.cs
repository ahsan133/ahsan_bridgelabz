using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class UnorderedList
    {
        static readonly string text = @"C:\Users\Admin\Desktop\ahsan\unordered.txt";
        public static void UnorderedListObj()
        {
            Utility list = new Utility();
            string[] s = File.ReadAllLines(text);
            foreach (string line in s)
                Console.WriteLine(line);
            list.Insert(2);
            list.Insert(4);
            list.Print();


        }
       
    }
}
 