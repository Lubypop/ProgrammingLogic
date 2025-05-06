using System;

namespace Lab8
{
  class Animal
  {
    // public string name = "Animal";    < --- may use this but not needed
    public virtual void animalSound()
    {
      Console.WriteLine("The animal is making sound...");
    }
  }
}
