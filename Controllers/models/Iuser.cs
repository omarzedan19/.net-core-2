using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public interface Iuser
    {
        void Adduser(User user);
        void Deleteuser(int id);
        List<User> GetAllUsers();
        User GetUser(int id);
    }
}
