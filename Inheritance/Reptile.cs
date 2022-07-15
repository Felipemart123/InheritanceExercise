using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

            Name = "gerald";
            HasLegs = 1;
            Age = 100;
            Color = "blue";
        }

        

        public string ColorOfScales{ get; set; }
        public bool EatsBugs { get; set; }
        public bool DoesShedSkin { get; set; }
        public bool LooksLikeADino { get; set; }
    }
}

