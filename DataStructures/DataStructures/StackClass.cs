// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StackClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StackClass<T>
    {
        public T[] present;
        public int max;
        public int top;
        public StackClass(int size)
        {
            max = size;
            top = -1;
            present = new T[size];
        }
        public void push(T data)
        {
            if (top == max-1)
            {
                Console.WriteLine("stack overflow");
                return;
            }
            else
            {
                present[++top] = data;
            }
        }
        public void Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            else
                --top;
        }
        public bool IsEmpty()
        {
            if (top < 0)
                return true;
            else
                return false;            
        }
        public void Print()
        {
            while(top>=0)
            {
                Console.Write(present[--top]+" ");
            }
        }
    }
}
