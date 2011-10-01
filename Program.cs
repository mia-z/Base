using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using c = System.Console;

namespace examples
{
    class Program
    {
        static void Main()
        {
            //int index = 1;
/*
            c.WriteLine("SEIZURE TIME!");
            
            do 
            {
                c.BackgroundColor = ConsoleColor.Blue;
                Random xr = new Random();
                int x = random.Next(0, 100);
                Random yr = new Random();
                int y = random.Next(0, 25);
                c.SetCursorPosition(x,y);

                c.BackgroundColor = ConsoleColor.Yellow;
                Random ar = new Random();
                int a = random.Next(0, 100);
                Random br = new Random();
                int b = random.Next(0, 100);
                c.SetCursorPosition(x, y);

                index = index + 1;
            } while (index <= 40);
*/
            c.WriteLine("Calling first function \n");
            Variables variables = new Variables();
            c.WriteLine("First function completed \n \n");
            c.ReadLine();

            c.WriteLine("Calling second function \n");
            Selection selection = new Selection();
            c.WriteLine("Second function finished \n \n");
            c.ReadLine();

            c.WriteLine("Calling third function \n");
            LoopsAndIfs loopsandifs = new LoopsAndIfs();
            c.WriteLine("Third function finished \n \n");
            c.ReadLine();
        }
    }
}