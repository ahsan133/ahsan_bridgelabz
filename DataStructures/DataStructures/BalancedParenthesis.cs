// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Balanced parenthesis using stack
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// Balances the parenthesis object.
        /// </summary>
        public static void BalancedParenthesisObj()
        {
            StackClass<char> stack = new StackClass<char>(20);
            string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            char[] chars = expression.ToCharArray();
            int n = chars.Length;
            for (int i = 0; i < n; i++)
            {
                if (chars[i] == '(')
                {
                    stack.push(chars[i]);
                }                 
                else if (chars[i] == ')')
                {
                    stack.Pop();
                }                    
            }

            stack.Print();
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
