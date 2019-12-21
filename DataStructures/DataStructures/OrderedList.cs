using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class OrderedList
    {
        static readonly string text = @"C:\Users\Admin\Desktop\ahsan\ordered.txt";
        static readonly string textRes = @"C:\Users\Admin\Desktop\ahsan\ordered_result.txt";
        public static void OrderedListObj()
        {
            Utility<int> list = new Utility<int>();
            string[] arr = File.ReadAllLines(text);
            
            int n = arr.Length;
            int i = 0;
            while(i!=n)
            {
                string[] a = arr[i].Split(" ");
                for(int j=0;j<a.Length;j++)
                {
                    int b= Convert.ToInt32(a[j]);
                    list.InsertAscending(b);
                }
                i++;
            }
            list.Print();
            Console.WriteLine();
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (list.Search(num))
                list.Remove(num);
            else
                list.InsertAscending(num);
            list.Print();
            int l = list.Size();
            string[] ar = new string[l];
            for (int k = 0; k < l; k++)
                ar[k] =(list.Get(k)).ToString();
            File.WriteAllLines(textRes, ar);
        }
    }
}
