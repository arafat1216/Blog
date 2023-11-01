using Blog.Models;

namespace Blog.Services
{
    public interface IBlogService
    {
        IEnumerable<BlogViewModel> GetAllBlogs();
    }
}
