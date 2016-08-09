using Microsoft.EntityFrameworkCore;

namespace Blog.Entities
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<Models.BlogPost> Blog { get; set; }
    }
}
