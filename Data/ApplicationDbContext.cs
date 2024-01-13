using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { Id=1,Title="Post1" ,Excerpt="This is first",Author="GRV"},
                new Post { Id=2,Title="Post2" ,Excerpt="This is second",Author="VSK"},
                new Post { Id=3,Title="Post3" ,Excerpt="This is third",Author="AKT"},
                new Post { Id=4,Title="Post4" ,Excerpt="This is forth",Author="SRV" }
               );
        }

    }
}
