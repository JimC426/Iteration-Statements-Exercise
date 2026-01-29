using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(int num1, int num2)
        {
            bool equal = (num1 == num2);

            if (equal)
            {
                Console.WriteLine($"{num1} and {num2} are equal."); 
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }

            return equal;
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int number)
        {
            bool even = (number % 2 == 0);

            if (even)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
            return even;
        }
      
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number)
        {
            bool positive = (number >= 0);

            if (positive)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            return positive;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static bool CanVote(int age)
        {
            bool adult = (age >= 18);

            if (adult)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
            }
            return adult;
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int number)
        {
            bool inRange = (number >= -10 && number <= 10);

            if (inRange)
            {
                Console.WriteLine("Your number is in range.");
            }
            else
            {
                Console.WriteLine("Your number is not in range.");
            }
            return inRange;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintEveryThirdNumber(); 
            //AreNumbersEqual(2,3);
            //IsEven(21);
            //IsPositive(-60);

            //Console.WriteLine("Please enter your age:");
            //CanVote(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Please enter a number between -10 and 10.");
            //int.TryParse(Console.ReadLine(), out int number);
            //IsInRange(number);

            //DisplayMultiplicationTable(10);
        }
    }
}
