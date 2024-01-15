using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Entities
{
    public class Article
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(10000)]
        public string Content { get; set; }

        public string Summary { get; set; }
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        [MaxLength(1000)]
        public string? ImagePath { get; set; }
    }
}
