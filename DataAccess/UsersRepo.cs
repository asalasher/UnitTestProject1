using Functions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataAccess
{
    public class UsersRepo : IUsersRepo
    {
        private const string _fileName = "userRepo.txt";
        private readonly string _fullPath;

        public UsersRepo()
        {
            _fullPath =
                Path.Combine(Environment.CurrentDirectory, "LocalDataStorage", _fileName);
        }

        public User GetById(int id)
        {
            return new User(2, "Alberto");
        }

        public List<User> GetDataFromFile()
        {
            string fileContent = File.ReadAllText(_fullPath);
            try
            {
                return JsonConvert.DeserializeObject<List<User>>(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool SaveDataInFile(List<User> data)
        {
            try
            {
                string serializedObj = JsonConvert.SerializeObject(data);
                File.WriteAllText(_fullPath, serializedObj);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
