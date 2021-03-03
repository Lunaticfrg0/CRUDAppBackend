﻿using CRUDAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUDAppBackend.UserData
{
    public class SqlUserData : IUserData
    {
        private UserContext _userContext;
        public SqlUserData(UserContext userContext)
        {
            _userContext = userContext;
        }
        public User AddUser(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
            return user;
        }

        public void DeleteUser(User user)
        {
            _userContext.Users.Remove(user);
            _userContext.SaveChanges();

        }

        public User GetUser(int id)
        {
            var user = _userContext.Users.Find(id);
            return user;
        }

        public List<User> GetUsers()
        {
            return _userContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();

        }
    }
}
