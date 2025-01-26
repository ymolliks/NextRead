using NextRead.Domain.Entities;

public interface IReadingLogRepository
{
    // Basic CRUD
    Task<ReadingLog?> GetByIdAsync(int id);
    Task<ReadingLog> CreateAsync(ReadingLog readingLog);
    Task UpdateAsync(ReadingLog readingLog);
    Task DeleteAsync(int id);

    // BookShelf-specific queries
    Task<IEnumerable<ReadingLog>> GetLogsByBookShelfIdAsync(int bookShelfId);
    Task<int> GetTotalPagesReadForBookShelfAsync(int bookShelfId);

    // Reading statistics
    Task<IEnumerable<ReadingLog>> GetUserReadingLogsAsync(int userId, DateTime? startDate = null,
        DateTime? endDate = null);

    Task<int> GetTotalPagesReadByUserAsync(int userId, DateTime? startDate = null, DateTime? endDate = null);
    Task<double> GetAveragePagesPerDayAsync(int userId, int lastNDays = 7);
}