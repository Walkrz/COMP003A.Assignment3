/* Author: Zachary Walker
* Course: COMP-003A-L01
* Purpose: Code for Assignment 3
*/
namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Numeric to letter grade using an if-else statement");

            // Input
            Console.Write("Enter a numeric grade (0-100): ");
            string input = Console.ReadLine();

            // Convert the response to a double or output error
            if (double.TryParse(input, out double numericGrade))
            {
                // Check if 0-100
                if (numericGrade >= 0 && numericGrade <= 100)
                {
                    // Determine letter grade and output
                    if (numericGrade >= 90)
                    {
                        Console.WriteLine("Letter Grade: A");
                    }
                    else if (numericGrade >= 80)
                    {
                        Console.WriteLine("Letter Grade: B");
                    }
                    else if (numericGrade >= 70)
                    {
                        Console.WriteLine("Letter Grade: C");
                    }
                    else if (numericGrade >= 60)
                    {
                        Console.WriteLine("Letter Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: F");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!"); // Invalid input not 0-100
                }
            }
            else
            {
                Console.WriteLine("Invalid input!"); //Invalid input for not even a number
            }

            // Title
            Console.WriteLine("***************************************");
            Console.WriteLine("Integer to string day using a switch statement");

            // Input
            Console.Write("Enter an integer Day of the week (1-7): ");
            string inputDay = Console.ReadLine();

            // Convert the response to an integer or output error
            if (int.TryParse(inputDay, out int numericDay))
            {
                // Output day
                switch (numericDay)
                {
                    case 1:
                        Console.WriteLine("String Day: Monday");
                        break;
                    case 2:
                        Console.WriteLine("String Day: Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("String Day: Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("String Day: Thursday");
                        break;
                    case 5:
                        Console.WriteLine("String Day: Friday");
                        break;
                    case 6:
                        Console.WriteLine("String Day: Saturday");
                        break;
                    case 7:
                        Console.WriteLine("String Day: Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day!");  // Number not 1-7
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid day!"); // same ting ~ drake toronto accent (not a number)
            }
        }
    }
}

