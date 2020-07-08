using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingCsharpBasics
{
    class SuperheroesCollection
    {

        //---- LIST ---- first try on my own
        public List<Superhero> superheroesList = new List<Superhero>();
        Superhero newSuperhero;
       
        public void AddSuperheroToList(Superhero newSuperhero)
        {
            superheroesList.Add(new Superhero(newSuperhero.HeroName, newSuperhero.Powers, newSuperhero.PowerObject, newSuperhero.Enemy, newSuperhero.HasSeriousTights, newSuperhero.TightsSeriousnessLvl));
        }

        public void AddANewSuperhero()
        {
            newSuperhero = new Superhero();
            newSuperhero.AddSuperhero();
            AddSuperheroToList(newSuperhero);
        }

        public void ShowSuperheroByID()
        {
            int counter = 1;
            foreach (Superhero superheroList in superheroesList)
            {
                superheroList.ShowSuperheroInfoWithID(counter);
                counter++;
            }
        }

        public void MenuOptions()
        {
            bool userPlaying = true;

            while (userPlaying)
            {
                Console.WriteLine("\nSuperhero Options\n");
                Console.WriteLine("1. Add a Supperhero to the Collection");
                Console.WriteLine("2. Interact with Superheros");
                Console.WriteLine("3. Exit");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddANewSuperhero();
                        break;

                    case "2":
                        ChooseSuperheroByID();
                        break;

                    case "3":
                        userPlaying = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void ChooseSuperheroByID()
        {
            Console.WriteLine("\nPlease SELECT the Superhero you'd like to interact with");
            ShowSuperheroByID();

            int userChoice = Convert.ToInt32(Console.ReadLine());

            Superhero newSuper = superheroesList[userChoice - 1];

            bool userIsPlaying = true;

            while (userIsPlaying)
            {
                Console.WriteLine("\nWhat would you like to do?\n");
                Console.WriteLine("1. Affect the seriousness of Superheroes tights level");
                Console.WriteLine("2. Interact with Superheroes");
                Console.WriteLine("3. Return to previous menu");
                Console.WriteLine("4. Exit");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        newSuper.PromtsAndChecksLvls();
                        break;
                    case "2":
                        ChooseSuperheroByID();
                        break;
                    case "3":
                        MenuOptions();
                        break;
                    case "4":
                        userIsPlaying = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
