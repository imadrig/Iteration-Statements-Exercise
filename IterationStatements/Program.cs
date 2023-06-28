using System;
using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //LukeWarm Section: Create methods below
            DecreaseNumbers();
            NumbersByThree();
            EqualNumbers(5, 6);
            EvenOrOdd(12);
            PositiveOrNegative(-13);
            MeetsVotingAge();

            //Heatin Up Section:
            IntInsideRange();
            MultiplicationTable();

        }
            //Write a method that will print to the console all numbers 1000 through - 1000 - DONE
            static void DecreaseNumbers()
            {
                Console.WriteLine("Decreasing numbers from 1,000 to -1,000");

                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                    
                }
                Console.WriteLine();
            }
            
            //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE
            static void NumbersByThree()
            {
                Console.WriteLine("Numbers by three (3-999)");

                for (int i = 3; i < 999; i += 3)
                {
                    Console.WriteLine(i);
                    
                }
                Console.WriteLine();
            }

            //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE
            static void EqualNumbers (int a , int b)
            {

                Console.WriteLine($"Check if a and b are equal: a = {a} and b = {b}");

                string areEqual = (a == b) ? "The numbers are equal." : "The numbers are not equal.";
                Console.WriteLine(areEqual);
                Console.WriteLine();

            }
            
            //Write a method to check whether a given number is even or odd
            static void EvenOrOdd(int number)
            {
                
                Console.WriteLine($"Checks if number is even or odd. The number is: {number}");

                string evenOrOdd = (number % 2 == 0) ? "The number is even." : "The number is odd.";
                Console.WriteLine(evenOrOdd);
                Console.WriteLine();

            }

            //Write a method to check whether a given number is positive or negative
            static void PositiveOrNegative(int number)
            {
                Console.WriteLine($"Checks if number is postive or negative. The number is: {number}");

                string postiveOrNegative = (number > 0) ? "The number is postive." : "The number is negative.";
                Console.WriteLine(postiveOrNegative);
                Console.WriteLine();

            }

            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()

            static void MeetsVotingAge()
            {
                
                Console.WriteLine($"How old are you?");
                string age = Console.ReadLine();

                int userAge;

                if (int.TryParse (age, out userAge))
                {
                    if (userAge >= 18)
                    {
                        Console.WriteLine("You are old enough to vote.");
                    }
                    else 
                    {
                        Console.WriteLine("You are NOT old enough to vote.");
                    }
                    Console.WriteLine();
                }
                
            }

            //Write a method to check if an integer(from the user) is in the range -10 to 10
            static void IntInsideRange()
            {
                Console.WriteLine($"Pick a number to determine if it's in the range -10 to 10:");
                string number = Console.ReadLine();

                int userNumber;

                if (int.TryParse (number, out userNumber)) 
                {
            
                    if (userNumber > 10 || userNumber < -10) 
                    {
                        Console.WriteLine("Your number is not within the specified range.");
                    }

                    else
                    {
                        Console.WriteLine("Your number is between -10 and 10!!");
                    }
                Console.WriteLine();
            }
                

            
            }

            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            static void MultiplicationTable()
            {
                int number = 9;
                
                for (int i = 1; i <= 12; i++) 
                {
                    int product = number * i;
                    Console.WriteLine($"{number} x {i} = {product}");
                }


                
            }
    }
}
