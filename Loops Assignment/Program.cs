using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Raihan Carder        
            Prompter();
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
    }
}
