using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class PostRepo: GenRepo<Post>, IPostRepo
    {
        private readonly AppDbContext dbContext;

        public PostRepo(AppDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }


       
      
    }
}
