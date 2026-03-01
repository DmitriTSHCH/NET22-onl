using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class BookDetailsRepository
    {
        private readonly LibraryDbContext _dbContext;
        public BookDetailsRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _summary, int _pageCount, string _language, int _edition, int _bookId)
        {
            var bookDetail = new BookDetail
            {
                Id = _id,
                Summary = _summary,
                PageCount = _pageCount,
                Language = _language,
                Edition = _edition,
                BookId = _bookId
            };
            _dbContext.Add(bookDetail);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _summary, int _pageCount, string _language, int _edition, int _bookId)
        {
            _dbContext.BookDetails
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Summary, _summary)
                .SetProperty(e => e.PageCount, _pageCount)
                .SetProperty(e => e.Language, _language)
                .SetProperty(e => e.Edition, _edition)
                .SetProperty(e => e.BookId, _bookId)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.BookDetails
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
