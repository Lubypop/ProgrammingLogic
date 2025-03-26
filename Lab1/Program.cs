namespace Lab1;



using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Security;
using Microsoft.VisualBasic;

class Program
  {
    static void Main(string[] args)
    {

        // Step 3a: Declare variables
        int myFavoriteNumber = 9;
        string myStringName = "My favorite number is ";
        string myFavoriteLanguage = "My favorite programming language is C#";
        double timeProgramming = 0.0;
        bool hasProgrammingExperience = false;

        // Step 5a: Declare a constant of school name
        const string MY_SCHOOL = "Cuyahoga Community College";

        // Step 1:
        // Print your name and course title using Console.WriteLine()
        Console.WriteLine("Name: Lauren Pierce");
        Console.WriteLine("Title: IT-1050");

        // Step 2:
        // Add a multi-line comment indicating Name: [Your Name] and Title: [IT-1050 - Lab 1]
        /*This is a multi-line comment. Name: Lauren Pierce 
        Course title: IT-1050*/
       
        // Step 3b: Print varialbles
        Console.WriteLine(myStringName + myFavoriteNumber);
        Console.WriteLine(myFavoriteLanguage);
        Console.WriteLine("I have programmed 0 times before this");
        Console.WriteLine("Has Programming experience: " + hasProgrammingExperience);

        // Step 5b: Display constant of school name 
        Console.WriteLine("I am a student at " + MY_SCHOOL);
        
        // Step 4: (null)

        // Step 5: Use Constants (above for best practice)

        // Step 6: Use Meaningful Identifiers (verified)
        int x = 5;
        int y = 10;
        Console.WriteLine(x + y);
    }
  }