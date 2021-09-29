using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_project.Controllers.models;

namespace test_project.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepo MyUser = null;
        private readonly IMapper _mapper;
         AppDbContext db;
        public UserController(IMapper mapper, IUserRepo MyUser,AppDbContext DB)
        {
            this.MyUser = MyUser;
            this._mapper = mapper;
            this.db = DB;
        }


        [HttpGet]
        public async Task<IEnumerable<User>> GetUser()
        {

            return await MyUser.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {

            return await MyUser.GetByID(id);
        }

        [HttpPost]
        public async Task Adduser( User user)
        {
            await MyUser.Add(user);

        }

        [HttpDelete("{id}")]
        public async Task Deleteuser(int id)
        {
            await MyUser.DeleteByID(id);

        }


        //[HttpGet]
        //public IActionResult GetUser()
        //{

        //    List<UserVeiwModel> UVM = _mapper.Map<List<User>, List<UserVeiwModel>>(MyUser.GetAll());
        //    return Ok(UVM);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetUser(int id)
        //{

        //    UserVeiwModel UVM = _mapper.Map<UserVeiwModel>(MyUser.GetByID(id));
        //    return Ok(UVM);
        //}

        //[HttpGet("{size}/{index}")]
        //public List<User> getPage(int size, int index)
        //{
        //    return db.users.Take(size).Skip(size * (index - 1)).ToList();
        //}

        //[HttpGet("getuserwithpost/{id}")]
        //public User getUserwithpost(int id)
        //{
        //    return db.users.Include(x => x.posts).FirstOrDefault(x => x.Id == id);
        //}





        // private readonly Iuser UR;
        //IUserRepo UR = null;

        //public UserController(IUserRepo ur)
        //{
        //   this.UR=ur;
        //}

        //[HttpGet]
        //public IEnumerable<User> GetAllUsers()
        //{
        //    return UR.GetAll();
        //}


        //[HttpPost]
        //public void Adduser([FromBody] User user)
        //{
        //    UR.Add(user);
        //}

        //[HttpDelete("{id}")]
        //public void Deleteuser(int id)
        //{

        //    UR.DeleteByID(id);
        //}



        //[HttpGet("{id}")]
        //public User GetUser(int id)
        //{
        //    return UR.GetByID(id);
        //}


        /* public UserController(Iuser firstuser)
         {
             dbContext = firstuser;
         }


         [HttpPost]
         public void Adduser( [FromBody] User user)
         {
             //dbContext.Adduser(user);
             dbContext.Add(user);

         }

         [HttpDelete("{id}")]
         public void Deleteuser(int id)
         {
             // dbContext.Deleteuser(id);
             dbContext.Remove(id);

         }

         [HttpGet]
         public List<User> GetAllUsers()
         {
           return  dbContext.GetAllUsers();
         }

         [HttpGet("{id}")]
         public User GetUser(int id)
         {
             return dbContext.GetUser(id);
         }
        */
    }

}
