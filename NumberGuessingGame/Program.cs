using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    // TODO: Create a console app that picks a random number and then gives the user 3 chances to guess it.

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                //TODO: Use our GenerateRandomNumber() method to generate the number and store it in a variable.

                int min = 1;
                int max = 20;
                int RndNum = GenerateRandomNumber(min, max);
                int Guess = 0;
                int Count = 0;

                //ask the user to guess a number between 1 and 20 (use console.writeline) 
                Console.WriteLine("I'm thinking of a number between {0} and {1}.  Can you guess it in 3 tries?", min, max);

                while (Guess < 3)
                {
                    while (Guess != RndNum)
                    {
                        Console.WriteLine("What number would you like to guess? ");

                        //store the users answer in a variable
                        int.TryParse(Console.ReadLine(), out Guess);
                        Count++;

                        for (int i = 0; i < 20; i++)

                            //use an if else conditional to determine if their guess is equal to yours 
                            if (Guess == i)
                            {
                                // With each incorrect answer tell the user if the correct answer is higher or lower.
                                if (Guess > RndNum)
                                {
                                    Console.WriteLine("Too high! Try again. ");
                                }

                                else if (Guess < RndNum)
                                {
                                    Console.WriteLine("Too low! Try again. ");
                                }

                                else
                                //if equal win, give them a win message
                                {
                                    Console.WriteLine("Correct! The number was " + RndNum + "!");
                                }

                            }

                    }

                }

                if (Guess > 3)
                {
                    Console.WriteLine("Sorry! You were not able to guess the nummber in 3 tries!");
                }


                    /*Console.WriteLine("Would you like to play again? Y or N ");

                    string rerun = Console.ReadLine();
                    if (rerun == "Y")
                    {
                        run = true;
                        Count = 0;
                        Console.Clear();
                    }

                    else if (rerun == "N")
                    {
                        run = false;
                    }*/
                




                //Console.WriteLine("Sorry that was not an acceptable value. Please enter a number between {0} and {1}. ", min, max);
                Console.ReadLine();
            }
        }

        //TODO: while loop for three guesses

        // At the end ask if they want to play again or end.
        public static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

    }



}
