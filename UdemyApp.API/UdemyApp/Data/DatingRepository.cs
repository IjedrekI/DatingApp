using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApp.Models;

namespace UdemyApp.Data
{
    //public class DatingRepository : IDatingRepository
    //{
    //    private readonly DataContext dataContext;

    //    public DatingRepository(DataContext dataContext)
    //    {
    //        this.dataContext = dataContext;
    //    }

    //    public void Add<T>(T entity) where T : class
    //    {
    //        dataContext.Add(entity);
    //    }

    //    public void Delete<T>(T entity) where T : class
    //    {
    //        dataContext.Remove(entity);
    //    }

    //    public async Task<User> GetUser(int id)
    //    {
    //        return await dataContext.Users
    //            .Include(p => p.MPhotos)
    //            .FirstOrDefaultAsync(p => p.Id == id); 
    //    }

    //    public Task<User> GetUser()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<IEnumerable<User>> GetUsers()
    //    {
    //        return await dataContext.Users
    //            .Include(p => p.MPhotos)
    //            .ToListAsync();
    //    }

    //    public Task<IEnumerable<User>> GetUsers(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<bool> SaveAll()
    //    {
    //        return await dataContext.SaveChangesAsync() > 0;
    //    }
    //}
}
