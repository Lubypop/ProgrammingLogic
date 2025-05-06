using System;
namespace Lab8
{
  class Program
  { 
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.animalSound();

        Animal myDog = new Dog();
        myDog.animalSound();

        Animal myCat = new Cat();
        myCat.animalSound();
    }
  }
}
