using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplicationTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a dictionary of game menu name and choice number
            Dictionary<string, string> gameChoices = new Dictionary<string, string>();
            gameChoices.Add("Multiplication Quiz", "1");
            gameChoices.Add("Division Quiz", "2");
            gameChoices.Add("")

            string input;
            int intA = 1;
            int intB = 2;
            bool inputTest;
            int tableMax = 100;
            int tableMin = 2;
            int minInt;
            int maxInt;
            int numTables;
            int answer;
            int numCorrect = 0;

            Random r1 = new Random(1);
            Random r2 = new Random(2);

            Console.WriteLine("Welcome to Multiplication Tables!");

            do
            {
                Console.Write("How many tables do you want to run (between {0} and {1}?  ", tableMin, tableMax);
                input = Console.ReadLine();
                numTables = Int32.Parse(input);
                inputTest = input == "" || numTables < tableMin || numTables > tableMax;
            } while (inputTest); //TODO: add a comparison to tell if input is a char or a string

            Console.Write("What is the largest integer (between 0 and 20) that you want to multiply by?  ");
            input = Console.ReadLine();
            maxInt = Int32.Parse(input);

            //create display for tables.
            for (int i = 0; i < numTables; i++)
            {
                //TODO: create random intA between zero and maxInt
                intA = r1.Next(maxInt);
                //TODO: create ramdom intB between zero and maxInt
                intB = r2.Next(maxInt);
                Console.WriteLine("What is {0} times {1}? ", intA, intB);
                input = Console.ReadLine();
                answer = Int32.Parse(input);
                if (answer == intA * intB)
                {
                    Console.WriteLine("Correct!");
                    numCorrect++;
                }
                else
                {
                    Console.WriteLine("That wasn't correct.");
                }

            }
            //at the end display the number correct out of the total number of tables
            Console.WriteLine("\nYou got {0} out of {1} correct.", numCorrect, numTables);

            Console.ReadLine();
        }
    }
}
