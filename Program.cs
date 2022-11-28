using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pizzaCost = 5.00m;
            string answerSize;
            //ask the user for pizza size
            Console.WriteLine("What pizza size do you want: small, medium, or large? Please type just s, m, or l, uppercase or lowercase.");
            //read in the input and convert it to uppercase
            answerSize = Console.ReadLine();
            string answerUpper = answerSize.ToUpper();
            //set the value of pizza cost based on size given by user
            switch (answerUpper)
            {
                case "S":
                    Console.WriteLine("You selected 'small', that will be $5.00.");
                    break;
                case "M":
                    Console.WriteLine("You selected 'medium', that will be $7.00.");
                    pizzaCost = 7.00m;
                    break;
                case "L":
                    Console.WriteLine("You selected 'large', that will be $9.00.");
                    pizzaCost = 9.00m;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            //ask for num of toppings
            Console.WriteLine("How many toppings do you want, 1, 2, or 0? Please type numbers or letters, all lowercase or all uppercase.");
            string answerNumber = Console.ReadLine();
            //add certain value to the pizza cost based on user input
            if (answerNumber == "2"|| answerNumber == "two" || answerNumber == "TWO")
            {
                pizzaCost = pizzaCost + 1.50m;
            }
            else if (answerNumber == "1"|| answerNumber == "one" || answerNumber == "ONE")
            {
                pizzaCost = pizzaCost + 1.00m;
            }
            //add 10% to the total cost
            pizzaCost = pizzaCost * 1.10m;
            //write out the total price to user
            Console.WriteLine("Your total bill is ${0:0.00}. Thank you for ordering!", pizzaCost);
            //this keeps the program from disappearing
            Console.ReadLine();
        }
    }
}
