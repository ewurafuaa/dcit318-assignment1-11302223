using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods{
    abstract class Shape{
        public abstract double GetArea();
    }

    class Circle : Shape{
        public double Radius;

        public Circle(double radius){
            Radius = radius;
        }

        public override double GetArea(){
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape {
        public double Length;
        public double Width;

        public Rectangle(double length, double width){
            Length = length;
            Width = width;
        }

        public override double GetArea(){
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Circle circle = new Circle(9);
            Rectangle rectangle = new Rectangle(15, 20);

            Console.WriteLine("Area of the Circle: " + circle.GetArea());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }
    }
}

