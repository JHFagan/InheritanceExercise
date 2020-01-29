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
            var penguin = new Bird();
            
            penguin.Legs = 2;
            penguin.Arms = 0;
            penguin.Eyes = 2;
            penguin.HasTail = true;
            penguin.Color = "Black and White";
            penguin.HasWings = true;
            penguin.HasFeathers = true;
            penguin.CanFly = false;

            Console.WriteLine($"This bird has {penguin.Legs} legs, {penguin.Arms} arms, and {penguin.Eyes} eyes. " +
                $"This bird has the following color(s): {penguin.Color}");
            if (penguin.CanFly == true)
            { Console.WriteLine("This bird can fly!"); }
            else
            { Console.WriteLine("This is a pathetic, flightless bird."); }
            if (penguin.HasWings == true)
            { Console.WriteLine("This bird has wings."); }
            else
            { Console.WriteLine("This bird is a wingless freak."); }
            if (penguin.HasFeathers == true)
            { Console.WriteLine("This bird has feathers."); }
            else
            { Console.WriteLine("This bird is a featherless lump of skin."); }



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var snake = new Reptile(0,0,2,true,false,true,true,false);
            Console.WriteLine($"Reptile Arms: {snake.Arms}");
            Console.WriteLine($"Reptile Legs: {snake.Legs}");
            Console.WriteLine($"Reptile Eyes: {snake.Eyes}");
            Console.WriteLine($"Reptile Has Tail: {snake.HasTail}");
        }
    }
}
