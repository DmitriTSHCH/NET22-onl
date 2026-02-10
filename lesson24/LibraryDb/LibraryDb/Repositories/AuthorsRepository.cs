using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class AuthorsRepository
    {
        private readonly LibraryDbContext _dbContext;
        public AuthorsRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _firstName, string _lastName, DateOnly _birthDate, string _country)
        {
            var author = new Author
            {
                Id = _id,
                FirstName = _firstName,
                LastName = _lastName,
                BirthDate = _birthDate,
                Country = _country
            };
            _dbContext.Add(author);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _firstName, string _lastName, DateOnly _birthDate, string _country)
        {
            _dbContext.Authors
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.FirstName, _firstName)
                .SetProperty(e => e.LastName, _lastName)
                .SetProperty(e => e.BirthDate, _birthDate)
                .SetProperty(e => e.Country, _country)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Authors
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
