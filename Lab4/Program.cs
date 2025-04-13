namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        // Write a for loop that prints the numbers from 1 to 10, each on a new line.
        for (int i = 1; i <= 10; i++)
        {
         Console.WriteLine(i);
        }

        // Write a for loop that loops through every number from 1 to 20, printing only even numbers.
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
             Console.WriteLine(i);
            }
        }

        // Create a while loop that prints numbers from 5 down to 1, counting backward.
        int b = 5;
        while (b >= 1)
            {
            Console.WriteLine(b);
            b--;
            }

        // Use a do/while loop to prompt the user to enter a number greater than 100.
        int number;
        do
            {
            Console.WriteLine("Enter a number greater than 100:");
            number = int.Parse(Console.ReadLine());
            }
            while (number <= 100);
            Console.WriteLine($"Valid number entered: {number}");

        //Use a while loop to print all multiples of 10 starting at 10 and ending at 1000 (inclusive).

            int number1 = 10; 
            while (number1 <= 1000) 
            {
            Console.WriteLine(number1); 
            number1 += 10; 
            }

        //Use nested for loops to print the triangle pattern122
        for (int i = 1; i <= 10; i++) 
        {
            
            for (int j = 1; j <= i; j++) 
            {
            Console.Write("*"); 
            }
            Console.WriteLine();
        }



    }
}

