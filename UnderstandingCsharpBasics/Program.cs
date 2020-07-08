using System;
using System.Collections.Generic;
using System.Linq;


namespace UnderstandingCsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //------//----above code was condenced into a method-------//-------//
            //Cat munchkinCat = new Cat("Munchkin", "Scottish Fold", "patterned gray", 4, 10);
            //{
            //    Console.WriteLine(" Tell us about yourself.");
            //    Console.WriteLine("I'm " + munchkinCat.Name + "! I am " + munchkinCat.Type + " type of cat, with "
            //    + munchkinCat.FurColor + " fur. " +
            //    "I have " + munchkinCat.Lives + " lives left, and I'm " + munchkinCat.Age + " years old");
            //    Console.WriteLine("This is " + munchkinCat.Name);
            //}

            ////------ CAT CLASS------
            //Cat munchkinCat = new Cat("Munchkin", "Scottish Fold", "patterned gray", 4, 10);
            //{
            //    munchkinCat.GreetingAndPrompt();
            //}
            //Cat munchingMunchkinCat = new Cat("Munching Munchkin", "Scottish Fold", "patterned orange", 8, 3);
            //{
            //    munchingMunchkinCat.GreetingAndPrompt();
            //}



            //------ SUPERHERO CLASS & SUPERHERO COLLECTION CLASS ONLY------
            Superhero newSuperhero = new Superhero();
            SuperheroesCollection superheroes = new SuperheroesCollection();

            superheroes.MenuOptions();



            //------ SUPERHERO CLASS ONLY ----Hardcoded Superheroes with out menu options------
            Superhero thorSuper = new Superhero("Thor", "God of thunder abilities and super strength", "Mjolnir", "Loki", true, 2);
            {
                thorSuper.SuperheroShowAndTell();
                Console.WriteLine("His power object is " + thorSuper.PowerObject + ". " +
                    "\nHis enemy is " + thorSuper.Enemy + ".");
                thorSuper.PromtsAndChecksLvls();
            }
            Superhero wonderWomanSuper = new Superhero("Wonder Woman", "Gliding through the air, strength and senses", "lasso and magical bracelets", "Paula von Gunther", false, 0);
            {
                wonderWomanSuper.SuperheroShowAndTell();
                Console.WriteLine("Her power objects are " + wonderWomanSuper.PowerObject + ". " +
                    "\nHer enemy is " + wonderWomanSuper.Enemy + ".");
                wonderWomanSuper.PromtsAndChecksLvls();
            }
            Superhero batmanSuper = new Superhero("Batman", "Fearlessness", "bat widgets", "the Joker", true, 7);
            {
                batmanSuper.SuperheroShowAndTell();
                Console.WriteLine("He technically has no powers but in RW thats as close as it gets. " +
                    "\nHis power objects are his " + batmanSuper.PowerObject + ". " +
                    "\nHis enemy is " + batmanSuper.Enemy + ".");
                batmanSuper.PromtsAndChecksLvls();
            }
            Superhero supermanSuper = new Superhero("Superman", "Flying, speed, fire from eyes, super hearing and super strength", "kryptonite and Lex Luther", true, 9);
            {
                supermanSuper.SuperheroShowAndTell();
                Console.WriteLine("He does not have an empowering object. " +
                    "\nHis enemy is " + supermanSuper.Enemy + ".");
                supermanSuper.PromtsAndChecksLvls();
            }
            Superhero ironManSuper = new Superhero("Iron Man", "Genious inventor in mechanical engineering and computer science", "super suits", 0);
            {
                ironManSuper.SuperheroShowAndTell();
                Console.WriteLine("He technically has no powers without his suits, but being a genious in RW is as close as it gets. " +
                    "\nHis power objects are his " + ironManSuper.PowerObject + ". " +
                    "\nHis enemy is cleaning up his own mess from a time of ignorance.");
                ironManSuper.PromtsAndChecksLvls();
            }
        }
    }
}
