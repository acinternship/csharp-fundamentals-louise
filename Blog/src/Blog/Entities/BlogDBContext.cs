using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.Entities
{
    public class BlogDbContext : IdentityDbContext<User>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {  

        }

        public DbSet<Models.BlogPost> Blog { get; set; }
    }
}
