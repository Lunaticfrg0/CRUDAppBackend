using CRUDAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppBackend.UserData
{
    public class MockUserData : IUserData
    {
        private List<User> users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Emilio Escano"
            },
            new User()
            {
                Id = 2,
                Name = "Lia Escano"
            }
        };
        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return users.SingleOrDefault(x => x.Id == id);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
