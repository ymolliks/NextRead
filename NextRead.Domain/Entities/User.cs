namespace NextRead.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string AvatarUrl { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }

    // Navigation properties
    public ICollection<BookShelf> BookShelves { get; set; } = new List<BookShelf>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}