using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class GenRepo<T>:IgenRepo <T> where T:class,IBM
    {
        private readonly AppDbContext dbContext;

        public GenRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(T user)
        {
           await dbContext.Set<T>().AddAsync(user);
           await dbContext.SaveChangesAsync();
        }

        public async Task DeleteByID(int id)
        {
            var filteredUsers = await dbContext.Set<T>().FirstOrDefaultAsync(T => T.Id.Equals(id));
            if (filteredUsers != null)
                dbContext.Set<T>().Remove(filteredUsers);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByID(int id)
        {
            return await dbContext.Set<T>().FirstOrDefaultAsync(user => user.Id.Equals(id));

        }

       
        //public void Add(T user)
        //{
        //    dbContext.Set<T>().Add(user);
        //    dbContext.SaveChanges();
        //}

        //public void DeleteByID(int id)
        //{
        //    var filteredUsers = dbContext.Set<T>().FirstOrDefault(T => T.Id.Equals(id));
        //    if (filteredUsers != null)
        //        dbContext.Set<T>().Remove(filteredUsers);
        //    dbContext.SaveChanges();
        //}

        //public List<T> GetAll()
        //{
        //    return dbContext.Set<T>().ToList();
        //}

        //public T GetByID(int id)
        //{
        //    return dbContext.Set<T>().FirstOrDefault(user => user.Id.Equals(id));

        //}




    }
}
