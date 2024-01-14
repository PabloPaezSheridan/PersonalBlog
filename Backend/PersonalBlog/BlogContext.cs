using Microsoft.EntityFrameworkCore;
using PersonalBlog.Entities;

namespace PersonalBlog
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
    }
}
