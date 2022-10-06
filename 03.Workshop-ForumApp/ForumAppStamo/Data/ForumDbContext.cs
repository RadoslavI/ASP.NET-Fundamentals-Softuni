using ForumAppStamo.Data.Configure;
using ForumAppStamo.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumAppStamo.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Post>(new PostConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts { get; set; }
    }
}
