/*
Author: George Ledbury
Date:   10/23/2019
CTEC 135: Microsoft Software Development with C#
​
Module 4: Programming Assignment 3, Problem 5
  * Create a class with two fields, one a string and the other an int. 
      The class implements the IComparable interface.
  * Create appropriate methods for the class
  * Objects in the class should be ordered in the following manner:
      - primary sort order is alphabetical according to the text field
      - secondary sort order is largest first according to the int field
  * Demonstrate the the objects can be sorted according to requirement
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create some objects to use for testing
            Prob5Class pc1 = new Prob5Class("Damian Lillard", 0);
            Prob5Class pc2 = new Prob5Class("CJ McCollum", 3);
            Prob5Class pc3 = new Prob5Class("Damian Lillard", 3);
            Prob5Class pc4 = new Prob5Class("CJ McCollum", 0);
            Prob5Class pc5 = new Prob5Class("Jusef Nurkic", 0);
            Prob5Class pc6 = new Prob5Class("Jusef Nurkic", 3);

            // test logic - expect positive, i.e. B follows A
            Console.WriteLine(pc1.CompareTo(pc2));
            Console.WriteLine();

            // put test objects in array
            Prob5Class[] pcArray = new Prob5Class[6];
            pcArray[0] = pc1;
            pcArray[1] = pc2;
            pcArray[2] = pc3;
            pcArray[3] = pc4;
            pcArray[4] = pc5;
            pcArray[5] = pc6;

            // sort array
            Array.Sort(pcArray);

            // print sorted array
            foreach (Prob5Class element in pcArray)
                Console.WriteLine(element);
        }
    }
}
