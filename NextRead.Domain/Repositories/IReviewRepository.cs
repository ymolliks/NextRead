using NextRead.Domain.Entities;

public interface IReviewRepository
{
    // Basic CRUD operations
    Task<Review?> GetByIdAsync(int id);
    Task<Review> CreateAsync(Review review);
    Task UpdateAsync(Review review);
    Task DeleteAsync(int id);

    // Book-specific operations
    Task<IEnumerable<Review>> GetReviewsByBookIdAsync(int bookId);
    Task<double> GetAverageRatingForBookAsync(int bookId);
    Task<int> GetReviewCountForBookAsync(int bookId);

    // User-specific operations
    Task<IEnumerable<Review>> GetReviewsByUserIdAsync(int userId);

    // Check if user has already reviewed
    Task<bool> HasUserReviewedBookAsync(int userId, int bookId);
    Task<Review?> GetUserReviewForBookAsync(int userId, int bookId);
}