using LibraryDb.Models;
using LibraryDb.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class BooksRepository
    {
        private readonly LibraryDbContext _dbContext;
        public BooksRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId)
        {
            var book = new Book
            {
                Id = _id,
                Title = _title,
                ISBN = _ISBN,
                PublicationYear = _publicationYear,
                Price = _price,
                AuthorId = _authorId,
                PublisherId = _publisherId
            };
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId)
        {
            _dbContext.Books
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Title, _title)
                .SetProperty(e => e.ISBN, _ISBN)
                .SetProperty(e => e.PublicationYear, _publicationYear)
                .SetProperty(e => e.Price, _price)
                .SetProperty(e => e.AuthorId, _authorId)
                .SetProperty(e => e.PublisherId, _publisherId)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Books
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
        public List<BookPublishedAfter2010Dto>? GetBookPublishedAfter2010()
        {
            var booksPublishedAfter2010 = _dbContext.Books
                .AsNoTracking()
                .Where(e => e.PublicationYear >= new DateOnly(2010, 1, 1))
                .Join(
                    _dbContext.Authors,
                    e => e.AuthorId,
                    j => j.Id,
                    (e, j) => new BookPublishedAfter2010Dto { Title = e.Title, PublicationYear = e.PublicationYear, AuthorName = $"{j.FirstName} {j.LastName}"})
                .ToList();

            return booksPublishedAfter2010;
        }
    }
}
