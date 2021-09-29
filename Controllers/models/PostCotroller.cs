using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_project.Controllers.models;

namespace test_project.Controllers.models
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class PostCotroller : ControllerBase
    {
        //IPostRepo pr = null;
        //public PostCotroller(IPostRepo pr)
        //{
        //    this.pr = pr;
        //}

        //[HttpGet]
        //public IEnumerable<Post> GetAllUsers()
        //{
        //    return pr.GetAll();
        //}


        //[HttpPost]
        //public void Adduser([FromBody] Post ps)
        //{
        //    pr.Add(ps);
        //}

        //[HttpDelete("{id}")]
        //public void Deleteuser(int id)
        //{

        //    pr.DeleteByID(id);
        //}



        //[HttpGet("{id}")]
        //public Post GetUser(int id)
        //{
        //    return pr.GetByID(id);
        //}
        IPostRepo posT = null;
        private readonly IMapper _mapper;
        AppDbContext dbc;
        public PostCotroller(IMapper mapper, IPostRepo P,AppDbContext DBC)
        {
            this.posT = P;
            this._mapper = mapper;
            this.dbc = DBC;
        }


        [HttpGet]
        public async Task<IEnumerable<Post>> Getpost()
        {

            return await posT.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Post> GetUser(int id)
        {
            return await posT.GetByID(id);
           
        }

        [HttpPost]
        public async Task AdduPost(Post po)
        {
            await posT.Add(po);

        }

        [HttpDelete("{id}")]
        public async Task Deletepost(int id)
        {
            await posT.DeleteByID(id);

        }



        //[HttpGet]
        //public IActionResult Getpost()
        //{

        //    List<PostVeiowModel> UVM = _mapper.Map<List<Post>, List<PostVeiowModel>>(p.GetAll());
        //    return Ok(UVM);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetUser(int id)
        //{

        //    PostVeiowModel UVM = _mapper.Map<PostVeiowModel>(p.GetByID(id));
        //    return Ok(UVM);
        //}

        //[HttpGet("{size}/{index}")]
        //public List<Post> getPage(int size, int index)
        //{
        //    return dbc.Posts.Take(size).Skip(size * (index - 1)).ToList();

        //}


    }
}
