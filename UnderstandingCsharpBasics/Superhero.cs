using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingCsharpBasics
{
    class Superhero
    {
        public string HeroName { get; set; }
        public string Powers { get; set; }
        public string PowerObject { get; set; }
        public string Enemy { get; set; }
        public bool HasSeriousTights { get; set; }
        public int TightsSeriousnessLvl { get; set; }


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

        public Superhero(string heroName, string powers, string enemy, bool hasSeriousTights, int tightsSeriousnessLvl)
        {
            HeroName = heroName;
            Powers = powers;
            Enemy = enemy;
            HasSeriousTights = hasSeriousTights;
            TightsSeriousnessLvl = tightsSeriousnessLvl;
        }

        public Superhero(string heroName, string powers, string powerObject, int tightsSeriousnessLvl)
        {
            HeroName = heroName;
            Powers = powers;
            PowerObject = powerObject;
            TightsSeriousnessLvl = tightsSeriousnessLvl;
        }


        public void SuperheroShowAndTell()
        {
            Console.WriteLine("\n__________________________________________________" +
                "\n" +
                "\nThis is " + HeroName + ". \n" + HeroName + " 's power is: " + Powers + ".");
        }

        public void CheckTightsSeriousnessLvl()
        {//sorry if anyone ever sees/reads this ... 
            Console.WriteLine("\n" + HeroName + "'s serious superhero tights level is " + this.TightsSeriousnessLvl + "!");
        }

        public int PromptToIncreaseLvl()
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

        public int PromptToDecreaseLvl()
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
            PromptToIncreaseLvl();
            CheckTightsSeriousnessLvl();
            PromptToDecreaseLvl();
            CheckTightsSeriousnessLvl();
        }
    }
}
