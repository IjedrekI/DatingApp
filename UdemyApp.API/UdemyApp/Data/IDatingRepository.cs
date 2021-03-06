﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApp.Models;

namespace UdemyApp.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers(int id);
        Task<User> GetUser();
    }
}
