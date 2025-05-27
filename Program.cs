using Task.data;
using Task.Model;

namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();
            var users = new List<User>
            {
                new User
                {
                    Name = "Alaa Rabaya",
                    Email = "alaa@example.com",
                    Password = "Password123"
                },
                new User
                {
                    Name = "Tariq Shreem",
                    Email = "Tariq@example.com",
                    Password = "Password123"
                },
                new User
                {
                    Name = "Laith Nuierat",
                    Email = "laith@example.com",
                    Password = "Password123"
                }
            };

            var blogs = new List<Blog>
            {
                new Blog
                {
                    Title = "Getting Started with ASP.NET Core",
                    description = "A beginner's guide to building web apps using ASP.NET Core.",
                    UserId = 1
                },
                new Blog
                {
                    Title = "Understanding Entity Framework Core",
                    description = "Deep dive into the EF Core ORM for .NET developers.",
                    UserId = 2
                },
                new Blog
                {
                    Title = "Top 10 C# Features Every Developer Should Know",
                    description = "Explore the most useful features in modern C# development.",
                    UserId = 1
                },
                new Blog
                {
                    Title = "Mastering Dependency Injection",
                    description = "How dependency injection works and how to use it effectively in .NET projects.",
                    UserId = 3
                },
                new Blog
                {
                    Title = "Building RESTful APIs with .NET 8",
                    description = "Step-by-step guide to creating RESTful APIs using the latest .NET version.",
                    UserId = 2
                }
            };

            context.Users.AddRange(users);
            
            context.SaveChanges();
            context.Blogs.AddRange(blogs);
            context.SaveChanges();
        }
    }
}
