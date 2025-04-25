using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  //Problem 1: Add a method to the Car class called Start() that prints "The car is starting."
  //Call myCar.Start() in the Main() method.
  public void Start()
  {
      Console.WriteLine("The car is starting.");
  }
//Problem 2: Add a Method with Parameters
//Add a method to the Car class called Drive that takes one int parameter named miles.
//The method should print:
//"The car drove X miles." (replace X with the miles passed in).
//Call myCar.Drive(50) in Main()
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + "miles.");
    }
//Problem 3: Add a Method with a Return Value
//Add a method to the Car class called GetDescription() that returns a string in the format:
//"2020 Black Civic" (you must use year, color, and model fields).
//In Main(), store the result in a variable and print it.
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }
//Problem 4: Add a Method that Updates a Field
//Add a method called Repaint that takes a string parameter and updates the color field.
//It should also print "The car has been repainted to X."
//To do this, you will callmyCar.Repaint("red") in Main(), print "The car has been repainted to " followed by myCar.color.
//Example Output after calling Repaint() with an argument of "red":
//The car has been repainted to red.
//myCar.color = "red";    public void Repaint(string newColor)
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {color}.");
    }

}


class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method
    myCar.Start(); // Calling the start method
    myCar.Drive(50); // Calling the drive 50 miles method
    string description = myCar.GetDescription();// Calling the GetDescription method
        Console.WriteLine("Car Description: " + description);
    myCar.Repaint("Pink"); // Calling the Repaint method
        Console.WriteLine("Updated Color: " + myCar.color);
  }
}