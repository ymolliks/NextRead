using NextRead.Domain.Enums;

namespace NextRead.Domain.Entities;

public class BookShelf
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int BookId { get; set; }
    public ShelfType ShelfType { get; set; }
    public int? CurrentPage { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? FinishDate { get; set; }

    // Navigation properties
    public User User { get; set; } = null!;
    public Book Book { get; set; } = null!;
}