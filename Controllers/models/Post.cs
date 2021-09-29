using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{

    [Table("POSTS")]
    public class Post :IBM
    {
        public Post()
        {
            
        }
        //public Post(int id, string title, string body)
        //{
        //    this.Id = id;
        //    this.title = title;
        //    this.body = body;
        //}

        [Key]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }
        public string body { get; set; }

        [ForeignKey("user1")]
        public int UserId { get; set; }

        [InverseProperty("posts")]
        public User user1 { get; set; }

        //[ForeignKey("")]
     //   public User Ruserid { get; set; }







    }
}
