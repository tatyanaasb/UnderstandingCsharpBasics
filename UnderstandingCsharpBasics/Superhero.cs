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


        public Superhero()
        {
        }

        public Superhero(string heroName, string powers, string powerObject, string enemy, bool hasSeriousTights)
        {
            HeroName = heroName;
            Powers = powers;
            PowerObject = powerObject;
            Enemy = enemy;
            HasSeriousTights = hasSeriousTights;
        }

        public Superhero(string heroName, string powers, string enemy, bool hasSeriousTights)
        {
            HeroName = heroName;
            Powers = powers;
            Enemy = enemy;
            HasSeriousTights = hasSeriousTights;
        }

        public Superhero(string heroName, string powerObject, bool hasSeriousTights)
        {
            HeroName = heroName;
            PowerObject = powerObject;
            HasSeriousTights = hasSeriousTights;
        }
    }
}
