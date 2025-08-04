using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces{
    interface IMovable{
        void Move();
    }

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

    class Program {
        static void Main(string[] args){
            Car myCar = new Car();
            Bicycle myBike = new Bicycle();

            myCar.Move();
            myBike.Move();
        }
    }
}