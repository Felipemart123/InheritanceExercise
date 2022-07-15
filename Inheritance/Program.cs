using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            var myBird = new Bird();
            myBird.ColorOfFeathers = "blue";
            myBird.DoesFly = true;
            myBird.IsAHunter = true;
            myBird.LivesInTrees = true;


            var myReptile = new Reptile();
            myReptile.ColorOfScales = "red";
            myReptile.DoesShedSkin = true;
            myReptile.LooksLikeADino = true;
            myReptile.EatsBugs = true;



            var myAnimal = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimal)
            {
                Console.WriteLine($"this animal {animal.Name} has a name");
                Console.WriteLine($"this animal has a {animal.Color} color");
                Console.WriteLine($"this animal is {animal.Age} years old");
                Console.WriteLine($"this animal has{animal.HasLegs} legs");
            }
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
