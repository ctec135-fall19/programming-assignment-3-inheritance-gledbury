/*
Author: George Ledbury
Date:   10/23/2019
CTEC 135: Microsoft Software Development with C#
​
Module 4: Programming Assignment 3, Problem 3
  * Demonstrate both the aggregation and composition relationships
  * 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "string from main";

            Problem3Class p3c = new Problem3Class(s);

            p3c.printState();
        }
    }
}
