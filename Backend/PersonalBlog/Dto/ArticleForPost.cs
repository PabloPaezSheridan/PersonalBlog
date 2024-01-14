using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Dto
{
    public class ArticleForPost
    {
        [Required]
        [MaxLength(10000)]
        public string Title { get; set; }
        [Required]
        [MaxLength(10000)]
        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [MaxLength(1000)]
        public string? ImagePath { get; set; }
    }
}
