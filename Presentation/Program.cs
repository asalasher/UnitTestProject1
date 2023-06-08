using DataAccess;
using Functions;
using Service;
using System;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User(1, "Alberto");
            Console.WriteLine("Adding positive points");
            user.AddPoints(1);
            Console.WriteLine(user.ToString());

            Console.WriteLine("Trying to add negative points");
            try
            {
                user.AddPoints(-1);
                Console.WriteLine(user.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("recording data to file");

            UserService userService = new UserService(new UsersRepo());
            bool status = userService.AddUser(user);

            if (status)
            {
                Console.WriteLine("user saved");
            }
            else
            {
                Console.WriteLine("user NOT saved");
            }

            Console.WriteLine("Adding more users");

            userService.AddUser(new User(2, "Maria"));
            userService.AddUser(new User(3, "Pedro"));
            userService.AddUser(new User(4, "Diego"));

            Console.WriteLine("printing users");
            var users = new UserService(new UsersRepo()).GetUsers();
            users.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine("Finishing the program");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();



            //User user = new User(1, "Alberto");

            //Console.WriteLine("Starting points");
            //Console.WriteLine(user.Points);

            //Console.WriteLine("Adding points");
            //user.AddPoints(2);

            //Console.WriteLine("New points");
            //Console.WriteLine(user.Points);

            ////Console.WriteLine("Writing to file");
            ////user.SaveToRepo();

            //Console.WriteLine("Reading file");
            //user.ReadRepo();

            //Console.WriteLine("Press any key");
            //Console.ReadKey();

        }
    }
}
