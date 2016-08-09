using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogPost
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Requerido")]
        [MaxLength(30), MinLength(3)]
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [MaxLength(30), MinLength(3)]
        public string Content { get; set; }
    }


}


