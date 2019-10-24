using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Problem3Class
    {
        //fields
        private string str;
        private string str2;

        // instantiate Problem3Class object
        public Problem3Class(string inStr)
        {
            // showing composition. Problem3Class owns str.
            // str doesn't exist outside of Problem3Class.
            str = "Composition Demo String";

            // showing aggragation.  str2 refers to an object
            // outside of Problem3Class.
            str2 = inStr;
        }

        // print method
        public void printState()
        {
            Console.WriteLine();
            Console.WriteLine("str {0}" + " is owned by Problem3Class.", str);
            Console.WriteLine();
            Console.WriteLine("str2 {0}" + " exists outside of Problem3Class", str2);
            Console.WriteLine();
        }
    }
}
