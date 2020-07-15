using System;

namespace MyFirstGitHubConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Prompt the user to enter their name.
            Console.WriteLine("Please enter your name:");
            
            // Decalre a string variable to hold the users name.
            string strName = string.Empty;
            
            // Retrieve data from User and store the calue in a strName variable.
            strName = Console.ReadLine();

            // Dispaly custom greeting
            Console.WriteLine($"Hello {strName}, Welcome to the bootcamp!");

            // Declare and Add 2 numbers
            int myFirstNumber = 200;
            int mySecondNumber = 10;

            // Print the Total to the Console App
            Console.WriteLine($"myFirstNumber: {myFirstNumber} plus mySecondNumber: {mySecondNumber} = {myFirstNumber + mySecondNumber}");

        }
    }
}
