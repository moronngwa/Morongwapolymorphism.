using Morongwapolymorphism;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Pig pig1 = new Pig();
        Dog dog1 = new Dog();
        Goat goat1 = new Goat();

        pig1.animalSound();
        dog1.animalSound();
        goat1.animalSound();
    }
}

