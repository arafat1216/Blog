using Blog.Models;

namespace Blog.Services
{
    public class BlogService : IBlogService
    {
        public IEnumerable<BlogViewModel> GetAllBlogs()
        {
            IEnumerable<BlogViewModel> blogs = new List<BlogViewModel>() 
            {
                new BlogViewModel
                {
                    BlogId = 1,
                    Title = "Create a CRUD app using .Net Core MVC",
                    ThumbnailImageUrl = "https://picsum.photos/500/500",
                    Description = "In this post we will create a CRUD app using .Net Core MVC step by step",
                    Author = "Mosh Hamedani",
                    PublishedDate = DateTime.Parse("05/07/2023"),
                },
                new BlogViewModel
                {
                    BlogId = 2,
                    Title = "Learn Angular",
                    ThumbnailImageUrl = "https://picsum.photos/800/800",
                    Description = "Learn Angular fundementals step by step with Typescript",
                    Author = "Mosh Hamedani",
                    PublishedDate = DateTime.Parse("08/02/2023"),
                },
            };

            return blogs;
        }
    }
}
