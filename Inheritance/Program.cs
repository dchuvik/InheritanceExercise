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

            Bird bird1 = new Bird()
            {
                size = "4 feet",
                feathersColor = "black and white",
                birdType = "penguin",
                canFly = false
            };

            Reptile reptile1 = new Reptile()
            {
                size = "8 cm",
                skinColor = "green and brown",
                reptileType = "gecko",
                canRegenerate = true
            };


            Console.WriteLine($"the {bird1.birdType} is {bird1.feathersColor} and is {bird1.size} tall. Flight ability: {bird1.canFly}.");
            Console.WriteLine();
            Console.WriteLine($"the {reptile1.reptileType} is {reptile1.skinColor} and {reptile1.size} long. Regeberation status: {reptile1.canRegenerate}");
        }

       
    }
}
