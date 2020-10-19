using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UVR8UE5;Database=TESTBLOG;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(

                new Blog { BlogId = 1, Url = "http://sample.com" },
                new Blog { BlogId = 2, Url = "http://www.tsn.ca" },
                new Blog { BlogId = 3, Url = "http://www.sportsnet.ca" },
                new Blog { BlogId = 4, Url = "http://www.theglobeandmail.com" },
                new Blog { BlogId = 5, Url = "http://www.quora.com" },
                new Blog { BlogId = 6, Url = "http://www.twitter.com" });


           //odelBuilder.Entity<Post>().HasData(
      /*new Post { PostId = 1, BlogId = 1, Title = "Sample post-test", Content = "test test test" },
      new Post { PostId = 1, BlogId = 2, Title = "Sports Headlines", Content = "Where's Travis Hamonic going to sign?" },
      new Post { PostId = 1, BlogId = 4, Title = "Canadian News", Content = "Justin Trudeau spends $100 more tax dollars!" },
      new Post { PostId = 1, BlogId = 6, Title = "Some Tweet", Content = "Th    is is my favorite dog, Hank!" },
      new Post { PostId = 2, BlogId = 6, Title = "Second Tweet", Content = "Beautiful day here in Calgary!!!" });
      */
        
            modelBuilder.Entity<Post>().HasData(
                new Post { BlogId = 1, PostId = 1, Title = "Sample post-test", Content = "test test test" },
                new Post { BlogId = 2, PostId = 2, Title = "Sports Headlines", Content = "Where's Travis Hamonic going to sign?" },
                new Post { BlogId = 4, PostId = 3, Title = "Canadian News", Content = "Justin Trudeau spends $100 more tax dollars!" },
                new Post { BlogId = 6, PostId = 4, Title = "Some Tweet", Content = "This is my favorite dog, Hank!" },
                new Post { BlogId = 6, PostId = 5, Title = "Second Tweet", Content = "Beautiful day here in Calgary!!!" });
        
        }
    }

    public class Blog
    {
       [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime Postdate { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
