using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 628;

            Console.WriteLine("Try to guess my favorite number between 1 and 1000");

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
               
                {
                Console.WriteLine("Too Low!");
                }

            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too High!");
            }


            else 
            {
                Console.WriteLine("Correct! Good Job.");
            }

            Console.WriteLine($"What is your favorite subject?");
            var response = Console.ReadLine();

            {
                switch (response)
                {
                    case "Math":
                        Console.WriteLine($"Math is a great way to keep your mind active!");
                        break;
                    case "English":
                        Console.WriteLine($"I love reading myself!");
                        break;
                    case "History":
                        Console.WriteLine($"History can teach us so much");
                        break;
                    case "Science":
                        Console.WriteLine($"A good experiment is always a fun way to learn");
                        break;
                    case "Gym":
                        Console.WriteLine($"It's always a good idea to work on your health and fitness");
                        break;
                    default:
                        Console.WriteLine($"I was never taught much about that");
                        break;
               
                }
            }
        }
    }
}
