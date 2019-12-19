using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmPrograms
{
    class RegEx
    {
        public static void RegExObj()
        {
            string s = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact" +
                " number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            Regex.Replace(s, "<<name>>", "md");
            Regex.Replace(s, "<<full name>>", "md ahsan");
            Regex rg = new Regex(@"91-xxxxxxxxxx");
            Regex r = new Regex(@"");

        }
    }
}
