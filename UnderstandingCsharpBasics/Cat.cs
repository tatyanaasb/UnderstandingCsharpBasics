using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingCsharpBasics
{
    class Cat
    {
        //private string name;
        //private string type;
        //private string furColor;
        //private int lives;
        //private int age;

        //public string Name 
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}
        //public string Type
        //{
        //    get { return this.type; }
        //    set { this.type = value; }
        //}
        //public string FurColor
        //{
        //    get { return this.furColor; }
        //    set { this.furColor = value; }
        //}
        //public int Lives
        //{
        //    get { return this.lives; }
        //    set { this.lives = value; }
        //}
        //public int Age
        //{
        //    get { return this.age; }
        //    set { this.age = value; }
        //}

        //---Short version of code on line 9 - 39. 
        public string Name { get; set; }
        public string Type { get; set; }
        public string FurColor { get; set; }
        public int Lives { get; set; }
        public int Age { get; set; }


        public Cat(string name, string type, string furColor, int lives, int age)
        {
            Name = name;
            Type = type;
            FurColor = furColor;
            Lives = lives;
            Age = age;
        }

        public void CatGreeting()
        {
            Console.WriteLine("I'm " + Name + "! I am " + Type + " type of cat, with "
            + FurColor + " fur. " + "I have " + Lives + " lives left, and I'm " + Age + " years old");
        }

        public void CheckLives()
        {
            Console.WriteLine("I have " + this.Lives + " lives left!");
        }

        public int PromptToLoseLife()
        {
            Console.WriteLine("Should " + Name + " lose a life? --Yes? or No?");
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("yes"))
            {
                Lives--;
            }
            return Lives;
        }
    }

}
