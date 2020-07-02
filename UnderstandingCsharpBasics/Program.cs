using System;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingCsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat munchkinCat = new Cat("Munchkin", "Scottish Fold", "paterned gray", 4, 20);
            //{
            //    Console.WriteLine(" Tell us about yourself.");
            //    Console.WriteLine("I'm " + munchkinCat.Name + "! I am " + munchkinCat.Type + " type of cat, with "
            //    + munchkinCat.FurColor + " fur. " +
            //    "I have " + munchkinCat.Lives + " lives left, and I'm " + munchkinCat.Age + " years old");
            //    Console.WriteLine("This is " + munchkinCat.Name);
            //}
            //----above code was condenced into a method and rewritten bellow
            {
                Console.WriteLine("Tell us about yourself.");
                munchkinCat.CatGreeting();

                munchkinCat.PromptToLoseLife();
                munchkinCat.CheckLives();
            }
        }
    }
}
