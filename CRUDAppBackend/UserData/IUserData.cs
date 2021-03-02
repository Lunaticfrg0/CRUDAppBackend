using CRUDAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppBackend.UserData
{
    public interface IUserData
    {
        List<User> GetUsers();

        User GetUser(int id);

        User AddUser(User user);

        void DeleteUser(User user);

        User UpdateUser(User user);
            
    }
}
