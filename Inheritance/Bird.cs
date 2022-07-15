using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Name = "bob";
            HasLegs = 2;
            Age = 1;
            Color = "green";
        }

        public string ColorOfFeathers { get; set; }
        public bool DoesFly { get; set; }
        public bool IsAHunter { get; set; }
        public bool LivesInTrees { get; set; }
    }
}

