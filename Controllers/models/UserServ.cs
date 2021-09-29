using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class UserServ : Iuser

    {
        private readonly AppDbContext dbContext;

        public UserServ(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /*
        public List<User> MyUsers = new List<User>
        {
        new User("omar",new DateTime(1999,5,8),"0547515816","omarzedan19@gmail.com",1),
        new User("omar",new DateTime(1999,5,8),"0547515816","omarzedan19@gmail.com",2),
        new User("omar",new DateTime(1999,5,8),"0547515816","omarzedan19@gmail.com",3),
        new User("omar",new DateTime(1999,5,8),"0547515816","omarzedan19@gmail.com",4),
        };
        
        public void Adduser(User user)
        {
            MyUsers.Add(user);
        }

        public void Deleteuser(int id)
        {
            var filteredUsers = MyUsers.FirstOrDefault(user => user.id.Equals(id));
            if (filteredUsers != null)
                MyUsers.Remove(filteredUsers);
        }

        public List<User> GetAllUsers()
        {
            return MyUsers;
        }

        public User GetUser(int id)
        {
            return MyUsers.FirstOrDefault(user => user.id.Equals(id));
        }
        
    }*/
        public void Adduser(User user)
        {
            dbContext.users.Add(user);
            dbContext.SaveChanges();
        }

        public void Deleteuser(int id)
        {
            var filteredUsers = dbContext.users.FirstOrDefault(user => user.Id.Equals(id));
            if (filteredUsers != null)
                dbContext.users.Remove(filteredUsers);
            dbContext.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return dbContext.users.ToList();
        }

        public User GetUser(int id)
        {
            return dbContext.users.FirstOrDefault(user => user.Id.Equals(id));

        }
    }
}
