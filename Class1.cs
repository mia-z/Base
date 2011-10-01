using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using c = System.Console;

namespace examples
{
    class Variables
    {
        public Variables()
        {
            int a = 5;
            int b = 60;
            double aa = 3.141;
            double bb = 66.66;
            bool funny = false;
            bool curlyhaired = true;
            char letterX = 'x';
            char letterY = 'y';
            string name = "Ryan";
            string enemy = "george";

            c.WriteLine("Variables assigned successfully");

            c.WriteLine(a + " <-- Integers --> " + b);
            c.WriteLine(aa + " <-- Doubles(Floating Point) --> " + bb);

            c.WriteLine("The following two lines contain boolean data types. The first with the value of false, the second with true.");
            if (funny == true)
            {
                c.WriteLine("You're funny, bro.");
            }
            else
            {
                c.WriteLine("You're not funny bro.");
            }

            if (curlyhaired == true)
            {
                c.WriteLine("Your hair is bad, bro.");
            }

            c.WriteLine(letterX + " <-- These two are char type --> " + letterY);
            c.WriteLine("These two are strings: This -> {0} and this -> {1}", name, enemy);

        }
    }
}
