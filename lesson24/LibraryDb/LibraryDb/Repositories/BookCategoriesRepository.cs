using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class BookCategoriesRepository
    {
        private readonly LibraryDbContext _dbContext;
        public BookCategoriesRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _bookId, int _categoryId, DateOnly _addedDate)
        {
            var bookCategory = new BookCategory
            {
                BookId = _bookId,
                CategoryId = _categoryId,
                AddedDate = _addedDate
            };
            _dbContext.Add(bookCategory);
            _dbContext.SaveChanges();
        }

        public void Update(int _bookId, int _categoryId, DateOnly _addedDate)
        {
            _dbContext.BookCategories
                .Where(e => e.BookId == _bookId)
                .Where(e => e.CategoryId == _categoryId)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.AddedDate, _addedDate)
                );
        }

        public void Delete(int _bookId, int _categoryId)
        {
            _dbContext.BookCategories
                .Where(e => e.BookId == _bookId)
                .Where(e => e.CategoryId == _categoryId)
                .ExecuteDelete();
        }
    }
}
