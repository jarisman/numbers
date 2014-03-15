using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main(string[] args)
        {
            Program number = new Program();
            
            int a = 0;
            int b = 0;
            
            Console.WriteLine("Welcome to 'Fun With Numbers!'");
            Console.WriteLine("Today we are going to practice multiplication.");
            Console.WriteLine("You will be asked a multiplication question.");
            Console.WriteLine("Something like, 'What is 5 times 5?");
            Console.WriteLine("If you think you know the answer, type it in.");
            Console.WriteLine("Enter 0 to exit.");

            // Create an object so that the program can call the equation method
            NumberMethods run = new NumberMethods();

            run.Equation(a, b);
  
        }
    }






    class NumberMethods
    {
        
        public String goodResponses()
        {
            String[] goodResponses = { "Good job", "Nice Work", "Well done", "Outstanding" };
            // Random number generator to select an index in the array 
            Random randNum = new Random();
            int i = randNum.Next(0, 4);
            // converts array output to a string so it can be passed to the return variable
            String good = goodResponses[i].ToString();


            return good;
        }

        public String badResponses()
        {
            String[] badResponses = { "No, please try again.", "Wrong. Try another number.", "Don't give up. Try again.", "No. Keep trying." };
            // Random number generator to select a random index in the array of responses
            Random randNum = new Random();
            int i = randNum.Next(0, 4);
            // Converts array output to a string so it can be passed to the bad variable
            String bad = badResponses[i].ToString();


            return bad;
        }


        public void Equation(int a, int b)
        {
           
            
            // random number generators for the two variables
            Random randNum = new Random();
            a = randNum.Next(1, 10);
            b = randNum.Next(1, 10);
            bool goodInput = false;
            int number;
            String userInput;
            // Prints equation to console
            Console.WriteLine("How much is " + a + " times " + b + "?");
            // Checks the user input 
            while (!goodInput)
            {
                // reads user input
                userInput = Console.ReadLine();
                // validation test of user input
                if (!int.TryParse(userInput, out number))
                {
                    // If user input is not an integer, prompts user to try a different input
                    Console.WriteLine("Please enter a valid number.");
                }
                // Checks for 0 input to exit the program
                else if (number == 0) return;
                // checks the user input against the correct answer.
                else if (number != (a * b))
                {
                    // wrong answer outputs
                    Console.WriteLine(badResponses());
                    Console.WriteLine("How much is " + a + " times " + b + "?");

                }
                else
                {
                    // right answer outputs
                    Console.WriteLine(goodResponses());
                    Equation(a, b);
                    // Recalls the entire method to give a new equation when the answer is correct
                    goodInput = true;
                }
                }
            }
        }
    
