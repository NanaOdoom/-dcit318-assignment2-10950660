using System;
namespace Assignment2{
    public interface IMovable{
        void Move();
        
        class Car : IMovable{
            public void Move() { 
                Console.WriteLine("Car is moving");
            }
        }
        class Bicycle : IMovable{
            public void Move(){
                Console.WriteLine("Bicycle is moving");
            }
        }

        static void Main(string[] args) {
            Car Lambo = new Car();
            Lambo.Move();

            Bicycle BMX = new Bicycle();
            BMX.Move();
        }
    }
}