using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.WriteLine("Please Enter your Name: ");
            //Assign variable to user name
            string myName = Console.ReadLine();
            //Display will show the collected name
            Console.WriteLine("You have a great day " + myName);
            //Used string interpolation (placeholder) to put values in string
            Console.WriteLine("Hey {0}, You're looking great today!!!",myName);
        }
    }
}
