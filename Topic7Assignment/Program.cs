namespace Topic7Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password, guess;
            password = "gangrene";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome To The Cool Kids Club");
            Console.WriteLine("What Is The Super Secret Password");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            guess = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();

            while (guess != password)
            {
                Console.WriteLine("Nuh Uh");
                Console.WriteLine("Try AGAIN!!!");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                guess = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
            }
            Console.WriteLine("Oh Hey That's Right");
            
        }
    }
}
