using System;
namespace Assignment2
{
    abstract class Shape{
        public abstract double GetArea();
    }
        class Circle : Shape{
            public double Radius { get; set; } 

            public override double GetArea(){
                return Math.PI * Math.Pow(Radius,2);
            }
        }
        class Rectangle : Shape{
            public double Lenght { get; set; }
            public double Width { get; set; }

            public override double GetArea(){
                return Width * Lenght;
            }
        }
        public class Abstract{
        static void Main(string[] args){
            Circle circle = new Circle(){Radius = 5};
            circle.GetArea();

            Rectangle rectangle = new Rectangle(){ Lenght = 8, Width = 8};
            rectangle.GetArea();
        }
    }
}