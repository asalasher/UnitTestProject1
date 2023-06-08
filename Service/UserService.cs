using DataAccess;
using Functions;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class UserService
    {
        private readonly UsersRepo _userRepo;

        public UserService(IUsersRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public List<string> GetUsers()
        {
            List<User> users = _userRepo.GetDataFromFile();
            return users.Select(x => x.ToString()).ToList();
        }

        public bool AddUser(User user)
        {
            List<User> users = _userRepo.GetDataFromFile();
            users.Add(user);

            bool status = _userRepo.SaveDataInFile(users);
            return status;
        }

    }
}
