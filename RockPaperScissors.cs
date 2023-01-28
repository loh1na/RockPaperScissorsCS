using System;
using System.Collections.Generic; 


namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, and wellcome to simple rock paper scissors game\nrules are simple. Just type rock or paper or scissors\nobviously you will play vs computer");
            while(true)
            {
                Console.WriteLine("Choose wisely!:");
                string player = Console.ReadLine();
                int player2 = guessed();
                switch (player)
                {
                    case "rock":
                        if (player2 == 3)
                            Console.WriteLine("you win!");
                        else if (player2 == 2)
                            Console.WriteLine("you lose");
                        else if (player2 == 1)
                            Console.WriteLine("draw");
                        break;
                    case "paper":
                        if (player2 == 1)
                            Console.WriteLine("you win!");
                        else if (player2 == 3)
                            Console.WriteLine("you lose");
                        else if (player2 == 2)
                            Console.WriteLine("draw");
                        break;
                    case "scissors":
                        if (player2 == 2)
                            Console.WriteLine("you win!");
                        else if (player2 == 1)
                            Console.WriteLine("you lose");
                        else if (player2 == 3)
                            Console.WriteLine("draw");
                        break;
                    default:
                        Console.WriteLine("type correct answer!");
                        break;
                }
            }
        }

        private static int guessed()
        {
            // 1 - rock
            // 2 - paper
            // 3 - scissors 
            Random rand = new Random();
            int value = rand.Next(1,4);
            return value;

        }
    }
}