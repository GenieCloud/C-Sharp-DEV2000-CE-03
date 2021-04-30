using System;
using System.Collections.Generic;

namespace Jones_James_CE03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * James M. Jones
             * 03/07/2021
             * DEV2000-O 02: Introduction to Development II
             * 1.8 Code Exercise 03: Lists
             */

            //Problem #1: Vacation Destinations

            //Greet the user and explain the purpose of this program.
            Console.WriteLine("Hello! This program will help you keep track of and count the number of places you will travel to in the next year.");

            //First, we want to creat an empty list called "vacationDestinations".
            List<string> vacationDestinations = new List<string>();

            //Next, we want to prompt the user for a location(s)
            //Additionally, I want to listen for the user's input and add it to the list.
            Console.WriteLine("Where would you like to travel to this year?");

            //This string will hold the user's input.
            string destinationsString = Console.ReadLine();

            //We must validation that the field is not left blank and re-prompt
            //the user to enter a destination.
            while (string.IsNullOrWhiteSpace(destinationsString))
            {
                //Remind the user to not leave the input blank.
                Console.WriteLine("Please do not leave this blank.");

                //Restate the intial question
                Console.WriteLine("Where would you like to travel to this year?");

                //Listen for the user's input again
                destinationsString = Console.ReadLine();
            }
            //This line adds the destination to vacationDestinations list.
            vacationDestinations.Add(destinationsString);

            //Restate the intial question
            Console.WriteLine("Would you like to add another destination?");

            string yesOrNo = "";

            //Listen for user's input
            yesOrNo = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(yesOrNo) || yesOrNo.ToLower() != "yes" && yesOrNo.ToLower() != "no" && yesOrNo.ToUpper() != "YES" && yesOrNo.ToUpper() != "NO")
            {
                //Remind the user to not leave the input blank.
                Console.WriteLine("Please enter yes or no only.");

                //Restate the intial question
                Console.WriteLine("Would you like to add another destination?");

                //Listen for user's input
                yesOrNo = Console.ReadLine();
            }
            //This while loop will run as long as the user inputs an answer of yes.
            while (yesOrNo.ToLower() == "yes" && yesOrNo.ToUpper() == "YES")
            {
                Console.WriteLine("Where else would you like to go?");
                //This will capture the user's input and save it to the list.
                destinationsString = Console.ReadLine();

                Console.WriteLine("Would you like to add another destination?");
                //Ask and capture the user's yes or no response.

                yesOrNo = Console.ReadLine();
                //add the input destination to the list.

                vacationDestinations.Add(destinationsString);
            }
            //if the user's is no during the 
            if (yesOrNo.ToLower() == "no" && yesOrNo.ToUpper() == "NO")
            {
                Console.WriteLine("You will take {0} trip(s) this year.",vacationDestinations.Count);

                for (int i = 0; i < vacationDestinations.Count; i++)
                {
                
                    Console.WriteLine("You will visit {0} this year.", vacationDestinations[i]);

                }
                    Console.WriteLine("Thank you for using the program and safe travels!");
            }
        }
    }
}