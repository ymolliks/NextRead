namespace NextRead.Domain.Entities;

public class ReadingLog
{
    public int Id { get; set; }
    public int BookShelfId { get; set; }
    public int PagesRead { get; set; }
    public string? Notes { get; set; }
    public DateTime LogDate { get; set; }

    // Navigation property
    public BookShelf BookShelf { get; set; } = null!;
}