using NextRead.Domain.Entities;

namespace NextRead.Domain.Repositories;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(int id);
    Task<IEnumerable<Book>> SearchAsync(string query);
    Task<Book> CreateAsync(Book book);
    Task UpdateAsync(Book book);
}