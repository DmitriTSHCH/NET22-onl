using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class AuthorBiographiesRepository
    {
        private readonly LibraryDbContext _dbContext;
        public AuthorBiographiesRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _education, string _awards, string _biographyText, int _authorId)
        {
            var authorBiography = new AuthorBiography
            {
                Id = _id,
                Education = _education,
                Awards = _awards,
                BiographyText = _biographyText,
                AuthorId = _authorId
            };
            _dbContext.Add(authorBiography);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _education, string _awards, string _biographyText, int _authorId)
        {
            _dbContext.AuthorBiographies
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Education, _education)
                .SetProperty(e => e.Awards, _awards)
                .SetProperty(e => e.BiographyText, _biographyText)
                .SetProperty(e => e.AuthorId, _authorId)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.AuthorBiographies
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
