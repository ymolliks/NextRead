using NextRead.Domain.Entities;

namespace NextRead.Domain.Repositories;

public interface IBookShelfRepository
{
    Task<BookShelf?> GetShelfByUserAndBookAsync(int userId, int bookId);
    Task AddToShelfAsync(BookShelf shelf);
    Task RemoveFromShelfAsync(int shelfId);
}