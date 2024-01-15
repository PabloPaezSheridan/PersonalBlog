using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Dto
{
    public class ArticleForPut
    {
        [MaxLength(10000)]
        public string? Title { get; set; }
        [MaxLength(10000)]
        public string? Content { get; set; }
        [MaxLength(1000)]
        public string? Summary { get; set; }
        public DateTime? Date { get; set; }
        [MaxLength(1000)]
        public string? ImagePath { get; set; }
    }
}
