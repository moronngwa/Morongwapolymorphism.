using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morongwapolymorphism
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says:wee wee");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says:bow woo");
        }
    }

    class Goat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The goat says:mee mee");
        }
    }
}

