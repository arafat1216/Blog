using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogViewModel
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
