using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Where do you live?");
            string userHome = Console.ReadLine();

            Console.WriteLine("What is your profession?");
            string userJob = Console.ReadLine();

            Console.WriteLine("What is your dream job?");
            string userDream = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName} who lived in {userHome}.");
            Console.WriteLine($"He worked as an {userJob}, though he didn't care for it very much.");
            Console.WriteLine($"His dream was to be a {userDream}");

        }
       
        
        
         

    }
}
