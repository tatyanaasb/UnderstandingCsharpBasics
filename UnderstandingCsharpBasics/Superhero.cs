using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingCsharpBasics
{
    class Superhero
    {
        //-------PROPERTIES----
        public string HeroName { get; set; }
        public string Powers { get; set; }
        public string PowerObject { get; set; }
        public string Enemy { get; set; }
        public bool HasSeriousTights { get; set; }
        public int TightsSeriousnessLvl { get; set; }

        //---------CONSTRUCTORS----
        public Superhero()
        {
        }

        public Superhero(string heroName, string powers, string powerObject, string enemy, bool hasSeriousTights, int tightsSeriousnessLvl)
        {
            HeroName = heroName;
            Powers = powers;
            PowerObject = powerObject;
            Enemy = enemy;
            HasSeriousTights = hasSeriousTights;
            TightsSeriousnessLvl = tightsSeriousnessLvl;
        }
        //----extra for practice---
        public Superhero(string heroName, string powers, string enemy, bool hasSeriousTights, int tightsSeriousnessLvl)
        {
            HeroName = heroName;
            Powers = powers;
            Enemy = enemy;
            HasSeriousTights = hasSeriousTights;
            TightsSeriousnessLvl = tightsSeriousnessLvl;
        }
        //----extra for practice---
        public Superhero(string heroName, string powers, string powerObject, int tightsSeriousnessLvl)
        {
            HeroName = heroName;
            Powers = powers;
            PowerObject = powerObject;
            TightsSeriousnessLvl = tightsSeriousnessLvl;
        }

        //----------METHODS----
        //umm sorry if anyone ever sees/reads this ... practice is practice 

        public void AddSuperhero()
        {
            Console.WriteLine("Superheroes name:");
            string heroName = Console.ReadLine();
            HeroName = heroName;

            Console.WriteLine($"{HeroName}'s power(s):");
            string powers = Console.ReadLine();
            Powers = powers;

            Console.WriteLine($"{HeroName}'s special power object:");
            string powerObject = Console.ReadLine();
            PowerObject = powerObject;

            Console.WriteLine($"{HeroName}'s enemy:");
            string enemy = Console.ReadLine();
            Enemy = enemy;

            Console.WriteLine($"(True or False) {HeroName} has serious Superhero tights aka rediculous costume with tights?");
            bool hasSeriousTights = Convert.ToBoolean(Console.ReadLine());
            HasSeriousTights = hasSeriousTights;

            if (HasSeriousTights == true)
            {
                Console.WriteLine($"On a scale of 1-10 enter the level of this Superheroes seriousness of tights.");
                int tightsSeriousnessLvl = Convert.ToInt32(Console.ReadLine());
                TightsSeriousnessLvl = tightsSeriousnessLvl;
            }
        }

        public void ShowSuperheroInfoWithID(int counter)
        {
            Console.WriteLine($"__________________________________________________\n");
            Console.WriteLine($"{counter}. This is {HeroName}");
            Console.WriteLine($"{HeroName}'s power(s): { Powers}");
            Console.WriteLine($"Special power object: {PowerObject}");
            Console.WriteLine($"Most known enemy: {Enemy}");
            if (HasSeriousTights == true)
            {
                Console.WriteLine($"This Superhero has some serious Superhero tights!");
                Console.WriteLine($"Current level/rating of Superhero tights is {TightsSeriousnessLvl}");
            }
            else
            {
                Console.WriteLine("This Superhero is too cool for tights!");
            }
        }

        private void CheckTightsSeriousnessLvl()
        {
            Console.WriteLine("\n" + HeroName + "'s serious superhero tights level is " + this.TightsSeriousnessLvl + "!");
        }

        private int PromptToIncreaseLvl()
        {
            Console.WriteLine("\nWould you like to feed " + HeroName + " healthy food? ---Yes? OR No?");
            string answerLog = Console.ReadLine();
            if (HasSeriousTights == false)
            {
                Console.WriteLine("This superhero is too cool for tights!");
            }
            else if (answerLog.ToLower().Equals("yes") && HasSeriousTights == true)
            {
                TightsSeriousnessLvl++;
            }
            return TightsSeriousnessLvl;
        }

        private int PromptToDecreaseLvl()
        {
            Console.WriteLine("\nWould you like to feed " + HeroName + " junk food? ---Yes? OR No?");
            string answerLog = Console.ReadLine();
            if (HasSeriousTights == false)
            {
                Console.WriteLine("This superhero is too cool for tights!");
            }
            else if (answerLog.ToLower().Equals("yes") && HasSeriousTights == true)
            {
                TightsSeriousnessLvl--;
            }
            return TightsSeriousnessLvl;
        }

        public void PromtsAndChecksLvls()
        {
            if (HasSeriousTights == true)
            {
                PromptToIncreaseLvl();
                CheckTightsSeriousnessLvl();
                PromptToDecreaseLvl();
                CheckTightsSeriousnessLvl();
            }
            else
                Console.WriteLine("This superhero is too cool for tights!");
        }



        //METHODS for the manual "hardcoded" Superheroes practice ONLY
        //Not related to the Menu options

        public void SuperheroShowAndTell()
        {
            Console.WriteLine("__________________________________________________" +
                "\n" +
                "\nThis is " + HeroName + ". \n" + HeroName + " 's power is: " + Powers + ".");
        }
    }
}
