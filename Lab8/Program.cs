using System;
namespace Lab8
{
  class Program
  { 
    static void Main(string[] args)
    {
      // Create a myCar object
      Animal myAnimal = new Animal();

      // Call the honk() method (From the Vehicle class) on the myCar object
      myAnimal.animalSound();

      // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
      Console.WriteLine(myAnimal.name + " " + myAnimal.name);
    }
  }
}
