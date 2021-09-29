using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class UserRepo : GenRepo<User>,IUserRepo
    {
        private readonly AppDbContext dbContext;

        public UserRepo(AppDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }

     
       
    }
}
