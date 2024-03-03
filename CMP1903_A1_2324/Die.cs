using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        public int _value; //creates a field so the value of the die can be accessed by other classes

        //Property
        public int value //creates a property of the class to store the value of the die 
        {
            get { return _value; } //returns the value of 'value'
            set { _value = value; } //stores the returned value into '_value'
        }

        //Method

        //this method generates a random number and returns it
        public int Roll(bool show) //initialises method 'Roll'
        {
            string choice = " "; //creates local variable to store user decision of re-rolling
            bool loop = true; //creates boolean variable to control circulation of while loop
            while (loop == true) //while loop created so user can re-do input if it does not meet requirements
            {
                Random rnd = new Random(); //creates a random number 
                value = rnd.Next(1, 6); //stores random number in set range of 1-6 in public variable 'value'
                if (show == false)
                {
                    return value;
                }

                try //attempts to accept user input
                {
                    Console.WriteLine($"\nnumber rolled = {value}");
                    Console.WriteLine("Do you want to roll again? (y/n): ");
                    choice = Console.ReadLine(); //stores user entered text into string 'choice'
                }
                catch (ArgumentNullException) //catches the exception if the user's input is null  (exception handling)
                {
                    Console.WriteLine("invalid input, please try again...\n"); //displays error message to user
                }
                catch (FormatException) //catches the exception if the user does not enter in the correct format (exception handling)
                {
                    Console.WriteLine("invalid input, please try again...\n"); //displays error message to user
                }

                if (choice == "n")
                {
                    loop = false;
                }
                else if (choice == "y")
                {
                    Console.WriteLine("Re-rolling...");
                }
                else
                {
                    Console.WriteLine("invalid input, please try again...\n");
                }
            }
            return value; //returns value of die 
        }
    }
}
