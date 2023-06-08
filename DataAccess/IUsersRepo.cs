using Functions;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IUsersRepo
    {
        User GetById(int id);
        List<User> GetDataFromFile();
        bool SaveDataInFile(List<User> data);
    }
}