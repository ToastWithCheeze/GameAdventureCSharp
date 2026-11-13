namespace GameAdventureCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Start();
        }
    }
}
public class Game
{
    public void Start()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        // Game logic goes here
        bool running = true;
        while (running)
        {
            Console.WriteLine("Säg ett nummer mellan 1 och 4");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Ur dead");
                    break;
                case 2:
                    Console.WriteLine("Maybe Dead ídk");
                    break;
                case 3:
                    Console.WriteLine("Maybe Alive heh");
                    break;
                case 4:
                    Console.WriteLine("u ran into a wall...");
                    break;
                default:
                    Console.WriteLine("Dumbass");
                    running = false;
                    break;
            }
        }
    }
}
