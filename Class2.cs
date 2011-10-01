using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using c = System.Console;

namespace examples
{
    class Selection
    {
        public Selection()
        {
            String name = "";
            String ageAsString = "";
            Int16 age;

            while (name == "")
            {
                c.WriteLine("Please enter your name");
                name = c.ReadLine();

                if (name == "")
                {
                    c.WriteLine("You didn't enter a name");
                }
            }

            c.WriteLine("Hello {0}", name);
            c.WriteLine("While-Loop finished, name entered successfully");

            do
            {
                c.WriteLine("Enter your age");
                ageAsString = c.ReadLine();
                if (ageAsString == "")
                {
                    c.WriteLine("No value entered, try again");
                }
            } while (ageAsString == "");
                    
            age = Int16.Parse(ageAsString);

            if (age <= 18)
            {
                c.WriteLine("You're too young, bro");
            }
            else
            {
                c.WriteLine("Welcome to the club, bro");
            }

            c.WriteLine();
            c.WriteLine("- String successfuly converted to Integer");
            c.WriteLine("- if/else passed successfuly");
            c.WriteLine("- do/while loop pased successfuly");
        }
    }
}
