//DYLAN GRANDJEAN
//Assignment 4 - Heart Rate
//Program designed to estimate a user's maximum heart rate and the safe range
//February 17th, 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Main
    {
        //Primary method which calls other methods
        static void Main(string[] args)
        {
            Heading();
            Information();
            UserInteractive();
        }

        //Method displays the header and current date
        private static void Heading()
        {
            Console.WriteLine("*******************************************************\n" + 
                              "\tHeart Rate Calculator App\n\n\t" + 
                              DateTime.Today.ToShortDateString());
        }

        //Displays information to the user
        private static void Information()
        {
            Console.WriteLine("*******************************************************\n" +
                              "This program will determine a safe range\n\tfor a heart rate while exercising.\n" +
                              "You will be asked to enter a name and age,\n");
        }

        //Part of the program which interacts with the user
        private static void UserInteractive()
        {
            //variable instantiation
            String name;
            double minSafeRange,
                   maxSafeRange;
            int age,
                maxHR;

            Console.WriteLine("*******************************************************");
            //Get users name
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            //Get user's age
            Console.Write("\nEnter age: ");
            age = int.Parse(Console.ReadLine());

            maxHR = 220 - age; 
            minSafeRange = maxHR * 0.5;
            maxSafeRange = maxHR * 0.85;

            Console.WriteLine("\n\t{0}\n" +
                              "Maximum Heart Rate is {1}\n" +
                              "Heart rate range is between {2} and {3}",
                              name, maxHR, Math.Round(minSafeRange), Math.Round(maxSafeRange));
            Console.Read();

        }
    }
}
