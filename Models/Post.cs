using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Excerpt { get; set; } 
        public string Author { get; set; }

    }
}
