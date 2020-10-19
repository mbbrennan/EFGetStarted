using System;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create

                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "https://www.flixtor.to/" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .Last();
       
                // Update
                Console.WriteLine("Updating the blog and adding a post");

                // Blog _newBlog = new Blog();

                blog.Posts.Add(
                    new Post
                    {
                        Title = "Marriage Story",
                        Content = "Good movie if not a bit sad.",
                        Postdate = DateTime.Now
                    }); ; ;
                db.SaveChanges();

                // Delete
              //  Console.WriteLine("Delete the blog");
              //  db.Remove(blog);
              //  db.SaveChanges();
            }
        }

      
        
    }

}
