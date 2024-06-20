using System;
namespace Assignment2{
    public interface IMovable{
        void Move();
    }
        class Car : IMovable{
            // void IMovable.Move() => This is also another way that totally overrides the class and the method...cannot be instantiated.
            public void Move(){ 
                Console.WriteLine("Car is moving");
            }
        }
        class Bicycle : IMovable{
            public void Move(){
                Console.WriteLine("Bicycle is moving");
            }
        }

    public class Interface{

        static void Main(string[] args) {
            Car Lambo = new Car();
            Lambo.Move();

            Bicycle BMX = new Bicycle();
            BMX.Move();
        }
    }
}
