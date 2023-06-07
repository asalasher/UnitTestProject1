using Functions;
using System;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola mundo");

            User user = new User(1, "Alberto");

            Console.WriteLine("Starting points");
            Console.WriteLine(user.Points);

            Console.WriteLine("Adding points");
            user.AddPoints(2);

            Console.WriteLine("New points");
            Console.WriteLine(user.Points);

            //Console.WriteLine("Writing to file");
            //user.SaveToRepo();

            Console.WriteLine("Reading file");
            user.ReadRepo();

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
