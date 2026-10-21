using System.Security.Principal;

namespace Topic7Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int mystery, mysteryGuess, roll1, roll2, tries = 0;
            string password, guess;
            bool done = false;
            password = "gangrene";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome To The Cool Kids Club");
            while (!done)
            {
                Console.WriteLine("What Is The Super Secret Password");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                guess = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Enter A Word That Doesn't Suck");
                tries++;
                if (password == guess)
                {
                    Console.WriteLine("Oh Hey That's Right");
                    done = true;
                }
                else if (tries == 5)
                {
                    Console.WriteLine("Oh Hey That's NOT RIGHT!!!!");
                    done = true;
                }
            }
            done = false;
            tries = 0;

            mystery = generator.Next(0, 11);
            Console.WriteLine("Guess A Number Between 1 And 10");
            while (!done)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                int.TryParse(Console.ReadLine(), out mysteryGuess);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Enter A Number That Doesn't Suck");
                tries++;
                if (mysteryGuess == mystery)
                {
                    Console.WriteLine("Oh Hey That's Right");
                    done = true;
                }
                else if (tries == 5)
                {
                    Console.WriteLine("I'm Going To Kill You");
                    done = true;
                }
            }

            Console.WriteLine("I'm Going To Roll Dice Now");
            roll1 = generator.Next(1, 7);
            roll2 = generator.Next(1, 7);
            while (roll1 != roll2)
            {
                Console.WriteLine(roll1 + " " + roll2);
                Console.WriteLine("Curses!");

                roll1 = generator.Next(1, 7);
                roll2 = generator.Next(1, 7);
            }
            Console.WriteLine(roll1 + " " + roll2);
            Console.WriteLine("Wow Doubles");
            int count = 0;
            Console.WriteLine("Say Something");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string message = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("No Wait A Number Actually");

            int amount;
            int.TryParse(Console.ReadLine(), out amount);
            while (count < amount)
            {
                Console.WriteLine((count + 1) + "." + message);
                count++;
            }
            Console.WriteLine("That's What You Sound Like");

            int quantity = 3;
            count = 0;
            int totalTwo = 0;
            int countTwo = 0;
            int promptNumber;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I'm going to ask for " + quantity + " nubers and will total them up for you.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Who Is That Guy");

            while (count < quantity)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("No Wait A Number Actually");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                int.TryParse(Console.ReadLine(), out promptNumber);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                totalTwo += promptNumber;
                count++;

            }
            Console.WriteLine("Total: " + totalTwo);
            Console.WriteLine("That's Weird");

            Console.WriteLine("Regardless It's Gambling Time");
            bool quit = false;
            string choice;
            int points = 3;
            int side;
            while (!quit)
            {
                if (points <= 0)
                {
                    Console.WriteLine("You're Broke!");

                    quit = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Points: " + points);
                    Console.WriteLine("Heads Or Tails Or Quit");
                    side = generator.Next(0, 3);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    choice = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (choice == "heads")
                    {
                        if (side == 1)
                        {
                            Console.WriteLine("Wow Very Good");
                            Console.WriteLine("+1 Point");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("The House Always Wins");
                            Console.WriteLine("-1 Point");
                            points--;
                        }
                    }
                    else if (choice == "tails")
                    {
                        if (side == 2)
                        {
                            Console.WriteLine("Wow Very Good");
                            Console.WriteLine("+1 Point");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("The House Always Wins");
                            Console.WriteLine("-1 Point");
                            points--;
                        }
                    }
                    else if (choice == "quit")
                    {
                        quit = true;
                        Console.WriteLine("Fine Be That Way");
                        Console.WriteLine("Final Score: " + points);

                    }
                    else
                    {
                        Console.WriteLine("That Is Not VALID");
                    }
                }
                
            }
        }
    }
}
