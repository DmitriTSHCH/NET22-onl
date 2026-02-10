using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class MembersRepository
    {
        private readonly LibraryDbContext _dbContext;
        public MembersRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _firstName, string _lastName, string _email, DateOnly _membershipDate)
        {
            var member = new Member
            {
                Id = _id,
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                MembershipDate = _membershipDate
            };
            _dbContext.Add(member);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _firstName, string _lastName, string _email, DateOnly _membershipDate)
        {
            _dbContext.Members
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.FirstName, _firstName)
                .SetProperty(e => e.LastName, _lastName)
                .SetProperty(e => e.Email, _email)
                .SetProperty(e => e.MembershipDate, _membershipDate)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Members
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
