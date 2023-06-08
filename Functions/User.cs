using System;
using System.IO;

namespace Functions
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; } = 0;

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool AddPoints(int points)
        {
            if (points == 0)
                return false;

            if (points < 0)
                throw new ArgumentException("points can not be negative");

            Points += points;
            return true;
        }

        // Wrinting a .txt file
        public bool SaveToRepo()
        {
            StreamWriter writer = new StreamWriter(".\\UsersRepository.txt");
            writer.WriteLine(ToString());
            writer.Close();

            return true;
        }

        // Reading a .txt file
        public bool ReadRepo()
        {
            StreamReader reader = new StreamReader(".\\UsersRepository.txt");
            string document = reader.ReadToEnd();
            //document.Split(new char[] { '\r', ',' });
            Console.WriteLine(document);
            return true;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Points:{Points}";
        }

    }
}
