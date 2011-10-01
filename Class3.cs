using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using c = System.Console;

namespace examples

{
    class LoopsAndIfs
    {
        public LoopsAndIfs()
        {
            c.ReadLine();

            Random random = new Random();
            int RandomNumber = random.Next(20);

            bool correct = false;
            int guess = 0;
            do
            {
                c.WriteLine("Type your guess");
                string guessAsString = c.ReadLine();
                guess = Int16.Parse(guessAsString);
                if (guess != RandomNumber)
                {
                    c.WriteLine("Incorrect guess");
                    if (guess > RandomNumber)
                    {
                        c.WriteLine("Guess too big");
                    }
                    if (guess < RandomNumber)
                    {
                        c.WriteLine("Guess too small");
                    }
                }
                else
                {
                    c.WriteLine("Correct!");
                    correct = true;
                }
            } while (correct == false);
        }
    }
}
