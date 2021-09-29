using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class User:IBM
    {
        public int Id { set; get; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
       // List<Post> Lst = new List<Post>();

        public User(int id, string name, string email, string phone, DateTime dOB, List<Post> lst, List<Post> getSetPost)
        {
            Id = id;
            this.name = name;
            Email = email;
            Phone = phone;
            DOB = dOB;
           // Lst = lst;
           // GetSetPost = getSetPost;
        }
        public User()
        {

        }

        public ICollection<Post> posts { get; set; }
       
          

        public ICollection<Post> Rposts { get; set; }
        }
    
        
    
    }

