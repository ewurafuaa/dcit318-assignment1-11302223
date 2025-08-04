using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo{
    class Animal {
        public virtual void MakeSound() {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal{
        public override void MakeSound(){
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal {
        public override void MakeSound() {
            Console.WriteLine("Meow");
        }
    }

    class Program {
        static void Main(string[] args){
            Animal a = new Animal();
            Dog d = new Dog();
            Cat c = new Cat();

            a.MakeSound();
            d.MakeSound();
            c.MakeSound();

        }
    }
}