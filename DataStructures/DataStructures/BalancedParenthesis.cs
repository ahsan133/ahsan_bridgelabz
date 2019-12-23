// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BalancedParenthesis
    {
        public static void BalancedParenthesisObj()
        {
            StackClass<char> stack = new StackClass<char>(20);
            string str = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            char[] ch = str.ToCharArray();
            int n = ch.Length;
            for(int i=0;i<n;i++)
            {
                if (ch[i] == '(')
                    stack.push(ch[i]);
                else if (ch[i] == ')')
                    stack.Pop();
            }
            stack.Print();
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
