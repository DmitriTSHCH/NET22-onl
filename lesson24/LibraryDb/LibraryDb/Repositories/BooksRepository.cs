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
        public List<BookAutorPublYearDto>? GetBookPublishedAfter2010()
        {
            var booksPublishedAfter2010 = _dbContext.Books
                .AsNoTracking()
                .Where(e => e.PublicationYear >= new DateOnly(2010, 1, 1))
                .Join(
                    _dbContext.Authors,
                    e => e.AuthorId,
                    j => j.Id,
                    (e, j) => new BookAutorPublYearDto { Title = e.Title, PublicationYear = e.PublicationYear, AuthorName = $"{j.FirstName} {j.LastName}"})
                .ToList();

            return booksPublishedAfter2010;
        }
        public List<ВookWithMultipleCategoriesDto>? GetBookWithMultipleCategories()
        {
            var booksWithMultipleCategories = _dbContext.BookCategories
                .AsNoTracking()
                .Join(
                    _dbContext.Categories,
                    e => e.CategoryId,
                    j => j.Id,
                    (e, j) => new { BookId = e.BookId, AddedDate = e.AddedDate, Category = j.Name}
                )
                .GroupBy(e => e.BookId)
                .Select(g => new { BookId = g.Key, Count = g.Count(), CategoriesAddedDatePair = g.ToDictionary(e => e.Category, e => e.AddedDate) })
                .Where(e => e.Count > 1)
                .Join(
                    _dbContext.Books,
                    e => e.BookId,
                    j => j.Id,
                    (e, j) => new ВookWithMultipleCategoriesDto { Title = j.Title, CategoriesAddedDatePair = e.CategoriesAddedDatePair }
                )
                .ToList();

            return booksWithMultipleCategories;
        }
        public List<BookAutorPublYearDto>? GetBooksWithoutLoan()
        {
            var booksWithoutLoan = _dbContext.Books
                .AsNoTracking()
                .Join(
                    _dbContext.Loans
                    .CountBy(e => e.BookId),
                    e => e.Id,
                    j => j.Key,
                    (e, j) => new { Title = e.Title, AuthorId = e.AuthorId, PublicationYear = e.PublicationYear, Count = j.Value }
                )
                .Where(e => e.Count < 1)
                .Join(
                    _dbContext.Authors,
                    e => e.AuthorId,
                    j => j.Id,
                    (e, j) => new BookAutorPublYearDto { Title = e.Title, PublicationYear = e.PublicationYear, AuthorName = $"{j.FirstName} {j.LastName}" }
                )
                .ToList();

            return booksWithoutLoan;
        }
        public List<BookPriceAvgPublisherBookPriceDto>? GetBooksPriceAvgPublisherBookPrice()
        {
            var bookPriceAvgPublisherBookPrice = _dbContext.Books
                .AsNoTracking()
                .Join(
                    _dbContext.Books
                        .GroupBy(e => e.PublisherId)
                        .Select(e => new { PublisherId = e.Key, AvgPublisherBookPrice = e.Average(e => e.Price) } ),
                    e => e.PublisherId,
                    j => j.PublisherId,
                    (e, j) => new BookPriceAvgPublisherBookPriceDto { Title = e.Title, Price = e.Price, AvgPublisherBookPrice = j.AvgPublisherBookPrice }
                )
                .Where(e => e.Price > e.AvgPublisherBookPrice)
                .ToList(); 

            return bookPriceAvgPublisherBookPrice;
        }
        public List<BookAuthorCategoriesLoanCount>? GetBookLoanCount()
        {
            var bookPriceAvgPublisherBookPrice = _dbContext.Books
                .AsNoTracking()
                .Join(
                    _dbContext.Authors,
                    e => e.AuthorId,
                    j => j.Id,
                    (e, j) => new { Title = e.Title, AuthorName = $"{j.FirstName} {j.LastName}", Id = e.Id}
                )
                .Join(
                    _dbContext.Loans
                    .CountBy(e => e.BookId),
                    e => e.Id,
                    j => j.Key,
                    (e, j) => new BookAuthorCategoriesLoanCount { Title = e.Title, AuthorName = e.AuthorName, LoanCount = j.Value }
                )
                .ToList();

            return bookPriceAvgPublisherBookPrice;
        }
    }
}
