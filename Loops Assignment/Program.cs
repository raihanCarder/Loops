using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Raihan Carder        
            
            string project;
            bool quit = false;

            Console.Title = "Topic 6 - Loops";
            while (!quit)
            {
                Console.Clear();

                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("Select one of the following projectsl:");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Percent Passing");
                Console.WriteLine("3. Oddsum");
                Console.WriteLine("4. Random Numbers");
                Console.WriteLine("5. Quit");
                Console.Write("Ignoring the numbers type what you would like to see: ");
                project = Console.ReadLine().ToUpper().Trim();
                Console.Clear();

                if (project == "PROMPTER")
                {
                    
                    Prompter();
                }
                else if (project == "PERCENT PASSING")
                {
                    PercentPassing();
                }
                else if (project == "ODDSUM")
                {
                    OddSum();
                }
                else if (project == "RANDOM NUMBERS")
                {
                    RandomNumbers();
                }
                else if (project == "QUIT")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Invalid, choice click enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.ReadLine();
        }

        public static void Prompter()
        {
            int minimum = 0, maximum = 0;
            double withinValues;
            bool validMinimum = false, validMaximum = false, inbetweenValues = false;

            Console.WriteLine("Prompter Assignment");
            Console.WriteLine();
            Console.Write("Enter a Minimum value: ");
            while (!validMinimum)
            {
                if (int.TryParse(Console.ReadLine(), out minimum))
                {
                    Console.WriteLine($"Your minimum value is: {minimum}.");
                    validMinimum = true;
                }
                else
                {
                    Console.Write("Invalid, Enter a minimum value: ");
                }
            }

            Console.WriteLine();
            Console.Write("Enter a maximum value: ");

            while (!validMaximum)
            {
                if (int.TryParse(Console.ReadLine(), out maximum)&& maximum>minimum)
                {
                    Console.WriteLine($"Your minimum value is: {maximum}.");
                    validMaximum = true;
                }
                else
                {
                    Console.Write("Invalid, Enter a maximum value: ");
                }
            }

            Console.Clear();

            while (!inbetweenValues)
            {
                Console.WriteLine($"Your minimum value is: {minimum}.");
                Console.WriteLine($"Your maximum value is: {maximum}.");
                Console.Write("Enter a value within that range: ");
                if (Double.TryParse(Console.ReadLine(),out withinValues)&&withinValues >= minimum && withinValues <= maximum)
                {
                    inbetweenValues = true;
                }
                else
                {
                    Console.WriteLine("That value is not within that range try again.");
                }
            }
            
            Console.WriteLine("You win, Press enter.");
            Console.ReadLine();
        }

        public static void PercentPassing()
        {
            int testsAmount = 0, aboveSeventy = 0, totalTests = 0;
            double testScore;
            bool validAmount = false;


            Console.WriteLine("Figure out your % of Tests above 70%!");
            Console.WriteLine();
            Console.Write("How many tests are you going to enter: ");
            while (validAmount == false)
            {
                if (int.TryParse(Console.ReadLine(), out testsAmount) && testsAmount > 0)
                {
                    validAmount = true;
                }
                else
                {
                    Console.Write("ERROR, How many tests are you going to enter: ");
                }
            }

            totalTests = testsAmount;

            for (int i = 1; i < totalTests+1; i++)
            {
                Console.Write($"Enter test mark {i}: ");
                if (double.TryParse(Console.ReadLine(), out testScore) && testScore >= 0 && testScore <= 100)
                {
                    if (testScore > 70)
                    {
                       aboveSeventy ++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid Entry, input will not be counted.");
                    testsAmount -= 1;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"You have inputted {testsAmount} valid tests.");
            Console.WriteLine($"The pourcentage of tests above 70% are: {(Math.Round((double)aboveSeventy /testsAmount * 100), 2)}%");
            Console.ReadLine();
        }

        public static void OddSum()
        {
            int input = 0, sum = 0;
            bool valid = false;

            Console.WriteLine("ODDSUM INTEGERS");
            Console.WriteLine();
            Console.Write("Enter an integer above 0: ");
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    valid = true;
                }
                else
                {
                    Console.Write("ERROR, enter an integer above 0: ");
                }
            }

            for (int i = 1; i < input+1; i+=2)
            {
                sum += i;
            }
            Console.WriteLine() ;
            Console.WriteLine($"The sum of all odd integers from 1 to the number entered is: {sum}.");
            Console.ReadLine();
        }

        public static void RandomNumbers()
        {
            int maximum = 0, minimum = 0, randomValue;
            bool validMinimum = false, validMaximum = false;
            string punctuation;
            Random generator = new Random();


            Console.WriteLine("Random Integer Numbers");
            Console.WriteLine();
            Console.Write("Enter a Minimum value: ");
            while (validMinimum == false)
            {

                if (int.TryParse(Console.ReadLine(), out minimum))
                {
                    validMinimum = true;
                }
                else
                {
                    Console.Write("Please enter a valid integer: ");
                }
            }
            Console.WriteLine();
            Console.Write("Enter a maximum value: ");

            while (validMaximum == false)
            {
                if (int.TryParse(Console.ReadLine(), out maximum) && maximum >= minimum)
                {
                    validMaximum = true;
                }
                else
                {
                    Console.Write("Enter a maximum value that's an integer and bigger than the minimum: ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("25 Values within those parameters are: ");

            for (int i = 0; i<25; i++)
            {
                if (i < 24)
                {
                    punctuation = ", ";
                }
                else
                {
                    punctuation = ".";
                }
                randomValue = generator.Next(minimum, maximum+1);

                Console.Write(randomValue + punctuation);
            }


            Console.ReadLine();
        }
    }
}
