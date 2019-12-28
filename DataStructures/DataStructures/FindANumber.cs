using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class FindANumber
    {
        static readonly string text = @"C:\Users\Admin\Desktop\ahsan\hashing.txt";
        public static void FindANumberObj()
        {
            Hashing<int, int> hash = new Hashing<int, int>();
            string[] s=File.ReadAllLines(text);
            for(int i=0;i<s.Length;i++)
            {
                string[] str = s[i].Split(" ");
                for (int j = 0; j < str.Length; j++)
                {
                    int a = Convert.ToInt32(str[j]);
                    int b = a % 11;
                    hash.Insert(b, a);
                }                    
            }
            hash.Print();
            Console.WriteLine("enter the number to search");
            int num = Utility.IsInteger(Console.ReadLine());
            int c = num % 11;
            if (hash.Search(num))
                hash.Remove(c,num);
            else
                hash.Insert(c,num);
            hash.Print();
        }
    }
}
