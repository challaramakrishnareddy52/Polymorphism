using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
        public void animalsound()
        {
            Console.WriteLine("The dog says : bow bow");
        }
        class Program
        {
            static void Main(string[] args)
            {

                Animal myAnimal = new Animal();
                Animal mypig = new pig();
                Animal myDog = new Dog();
                myAnimal.animalsound();
                mypig.animalsound();
                myDog.animalsound();
            }
        }
    }
}
