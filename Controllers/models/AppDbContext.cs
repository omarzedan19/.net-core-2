using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        /*
        protected override void onModleCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(Entity =>
            {
                Entity.HasOne<Post>().WithOne(p=>p.user1)

            });
        }
        */
        public DbSet<User> users { get; set; }
        public DbSet<Post> Posts { get; set; }





    }
}
