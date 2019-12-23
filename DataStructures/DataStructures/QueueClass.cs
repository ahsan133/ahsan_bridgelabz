// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class QueueClass<T>
    {
        public int first=0;
        public int last=0;
        public T[] que;
        public QueueClass(int size)
        {
            que = new T[size+1];
        }
        public void Add(T data)
        {
            que[++last] = data;
        }
        public void Remove()
        {
            if(last==0)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            for (int i = 1; i <last;i++)
            {
                que[i] = que[i + 1];
            }
            last--;
        }
        public void Print()
        {
            for(int i=1;i<=last;i++)
                Console.Write(que[i]+" ");
            Console.WriteLine();
        }
    }
   
}
