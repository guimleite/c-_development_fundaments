using System.ComponentModel;

namespace GuisBookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { set; get; }
        public string? LongDescription { set; get; }
        public string? AuthorInformation { set; get; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsBookOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
