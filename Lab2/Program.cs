namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1a. Declare variables using the following data types and assign appropriate values:
            int myNum = 1100000;
            Console.WriteLine(myNum);

            double myDoubleNum = 18.99D;
            Console.WriteLine(myDoubleNum); // Step 2b. Print each variable to the console

            float myFloatNum = 3.1F;
            Console.WriteLine(myFloatNum);

            char favoriteLetter = 'A';
            Console.WriteLine(favoriteLetter);

            bool isSummerBest = true;
            Console.WriteLine(isSummerBest);

            string myString = "I Love Programming!";
            Console.WriteLine(myString);

        //Step 2. Part 2: Type Casting--Create a double variable and assign it a value with decimal places 9.78.
            double doubleNum = 9.78;
            Console.WriteLine(doubleNum);


        // Step 2a. Convert this double to an int using explicit casting.
            double myDouble = 9.78;
            int myInt = (int) myDouble;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt); 


        // Step 2b. Use the Convert class to:
        // Step 2c. Convert an int to a string
            int myInt1 = 5;
            Console.WriteLine(Convert.ToString(myInt1));


        // Step 2.d Convert a bool to a string
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine("int: " + myInt1);
            Console.WriteLine("bool: " + myBool);


        // Print each value with a label (i.e., Console.WriteLine("double: " + doubleValue);
        // Part 3: User Input and Type Conversion
        // Step 1a Prompt the user to enter their name and store it in a string.
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);


        // Step 2a Prompt the user to enter their age. Use Console.ReadLine() and convert it to an int using Convert.ToInt32().
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Hey " + userName + "! " + "You're " + age + " years old!");


        //
        
        
        }
    }
}



