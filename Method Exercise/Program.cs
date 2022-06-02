using System;

namespace Method_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome, {userName}, what is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine($"WOW! Never thought of the color {userColor}. Good choice! Where are you from?");
            string userCity = Console.ReadLine();

            Console.WriteLine($"I heard only steers and deers come from {userCity}. Just teasing!");
            Console.WriteLine("What's your favorite hobby?");
            string userHobby = Console.ReadLine();

            Console.WriteLine($"Soooooooo, this is how you spend your time? {userHobby}ing? Hmph.");

            Console.WriteLine($"I seen {userName} {userHobby}ing last week. I thought to myself maybe you shouldnt do that in public..");
            Console.WriteLine($"But {userName} wasn't alone, there was a group of them {userHobby}ing in the middle of the mall..");
            Console.WriteLine($"They were all wearing {userColor} shirts and gray pants! Some with no pants!");
            Console.WriteLine($"If you want to avoid seeing an awkward situation..dont go to {userCity}..at least not till summer hahah!");






        }
    }
}