using System;
namespace Assignment2{
    class Animal{ //base class created
            public virtual void MakeSound(){ // method created to print out some generic sounds as long as Animal is concerned. The keyword virtual is used in becuase of its future inheritance
                Console.WriteLine("Some generic sounds"); // Output for the method MakeSound
            }
        

        class Dog : Animal{ // New object called Dog, inheriting methods from Animal
            public override void MakeSound(){ // The MakeSound() method is overridden in the system to out put a sound known as Bark
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal{ // New Object created known as Cat that inherits from Animal
            public override void MakeSound() // The MakeSound() method is overridden from the Base class and changed here to output "Meow"
            {
                Console.WriteLine("Meow");
            }
        }

        static void Main(string[] args){ // Main method created to make the program completes

            Animal Animal = new Animal(); // Animal is instantiated as Animal
            Animal.MakeSound(); // MakeSound() method for Animal is called

            Dog Scobby = new Dog(); // Dog is instantiated as Scooby
            Scobby.MakeSound(); // MakeSound() for Dog is called

            Cat Puss = new Cat(); // Cat is instantiated as Puss
            Puss.MakeSound(); // MakeSound() for  Cat is called
        }
    }
}