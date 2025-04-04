using System.ComponentModel.Design;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Declare three integer variables: a = 10, b = 5, and c = 15.
            int A = 10;
            int B = 5;
            int C = 15;  
    
        //Use comparison and logical operators to:
        //Check if a is greater than b
            Console.WriteLine(A > B);

        //Check if a is less than c
            Console.WriteLine(A < C );

        //Check if a is greater than both b and c
            Console.WriteLine( A > B && A > C);

        //Combine expressions using && and ||
            Console.WriteLine(A > B || A >C );

 //Part 2: Boolean Logic
        //Declare a bool variable called isRaining and set it to true.
            bool isRaining = true;

        // Declare another bool variable haveUmbrella and set it to false.
            bool haveUmbrella = false;

        //Write an if statement to print:
        //"Take an umbrella!" if it’s raining and you don’t have one.
        // "You're good to go!" otherwise.

            if (isRaining) 
          { 
            Console.WriteLine("Take an Umbrella!");
          }
          else
          {
         
            Console.WriteLine("You're good to go!");
          }
        
//Part 3: Conditional Logic – Movie Ticket Pricing
//Write a program that asks the user to enter their age. Based on their age, display the ticket price category:
    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
  //If the age is less than 5, display: "Ticket is free!"
    if (age < 5)
    Console.WriteLine ("Ticket is free!");

  //If the age is between 5 and 12, display: "Child ticket: $5"
    else if (age >=5 && age <= 12)
    Console.WriteLine ("Child ticket: $5");

  //If the age is between 13 and 64, display: "Standard ticket: $10"
    else if (age >= 13 && age <= 64)
    Console.WriteLine("Standard ticket: $10");
  //If the age is 65 or older, display: "Senior ticket: $6"
    else if (age >=65)
    Console.WriteLine("senior ticket:$6");
  //Use int.Parse(Console.ReadLine()) (or Convert.ToInt32()) to read and parse the user’s input.
       

//Part 4: Using a switch Statement
  //Write a program that asks the user to enter a day of the week (1–7). Use a switch statement to display the name of the corresponding day:

//1 - Monday
//2 - Tuesday
//3 - Wednesday
//4 - Thursday
//5 - Friday
//6 - Saturday
//7 - Sunday

//If the user enters an invalid number, display: “Invalid day!”
      


      








    }
}
