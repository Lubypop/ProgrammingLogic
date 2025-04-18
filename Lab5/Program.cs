namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
      //Problem 1: Seasons of the Year
      //Declare and initialize a string array named seasons with the four seasons: "Spring", "Summer", "Fall", and "Winter".
      //Use a foreach loop to display each season.
      string[] seasons = new string [4];
      seasons[0] = "Spring";
      seasons[1] = "Summer";
      seasons[2] = "Fall";
      seasons[3] = "Winter";

    foreach (string season in seasons)
    {
      Console.WriteLine(season);
    }
    //Problem 2: Days of the Week (1–7)
    //Create an array named days with 7 strings representing the days of the week starting from Monday.
   /* 
    String [] days = new string[7];
    days[0] = "Monday";
    days[1] = "Tuesday";
    days[2] = "Wednesday";
    days[3] = "Thursday";
    days[4] = "Friday";
    days[5] = "Saturday";
    days[6] = "Sunday";
 */
     // Problem 2: Days of the Week (1–7)
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine($"The day is {days[dayNumber - 1]}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        
        {
       // Problem 3: Favorite Books and Authors
       // Create arrays for books and authors
            string[] books = { "The Cuckoo’s Egg: Tracking A Spy Through The Maze Of Computer Espionage", "The Great Gatsby", "A Time to Kill" };
            string[] authors = { "Cliff Stoll", "F. Scott Fitzgerald", "John Grisham" };

            // Check if the arrays have matching lengths
            if (books.Length == authors.Length)
            {
                // Use a for loop to print each book and its corresponding author
                for (int i = 0; i < books.Length; i++)
                {
                Console.WriteLine($"{books[i]} by {authors[i]}");
                }
            }
            else
            {
            Console.WriteLine("Error: The books and authors arrays are not the same length.");
            }
        }
//Problem 4: Temperature Tracker
//Create an int[] temperatures = { 65, 72, 78, 70, 68 };
    int[] temperatures = { 65, 72, 78, 70, 68 };
//Print the temperatures in ascending order using Array.Sort().
    Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
        Console.WriteLine(temp);
        }
//Print the highest and lowest temperatures.
    int lowest = temperatures[0];
        int highest = temperatures[temperatures.Length - 1];
        Console.WriteLine($"\nLowest temperature: {lowest}");
        Console.WriteLine($"Highest temperature: {highest}");


// Problem 5: Reverse Countdown
//Declare an int array named countdown with values { 5, 4, 3, 2, 1 }.
    int[] countdown = { 5, 4, 3, 2, 1 };
//Use Array.Reverse() to reverse it.
     Array.Reverse(countdown);
//Display the new order with a for loop.    
    Console.WriteLine("Countdown in reverse order:");
    for (int i = 0; i < countdown.Length; i++)
    {
     Console.WriteLine(countdown[i]);
    }


    }
}

           