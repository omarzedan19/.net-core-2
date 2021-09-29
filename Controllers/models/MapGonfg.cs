using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class MapGonfg:Profile
    {
     public MapGonfg()
        {
            CreateMap<User, UserVeiwModel>().ReverseMap();
            CreateMap<Post,PostVeiowModel>().ReverseMap();
        }
    }
}
