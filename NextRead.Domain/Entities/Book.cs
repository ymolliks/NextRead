namespace NextRead.Domain.Entities;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string CoverImageUrl { get; set; }
    public string ISBN { get; set; }
    public int TotalPages { get; set; }
    public DateTime PublishedDate { get; set; }

    // Navigation property
    public ICollection<BookShelf> BookShelves { get; set; } = new List<BookShelf>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}