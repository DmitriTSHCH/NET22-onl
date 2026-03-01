using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace LibraryDb.Repositories
{
    public class MemberContactsRepository
    {
        private readonly LibraryDbContext _dbContext;
        public MemberContactsRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _phone, string _address, string _city, int _memberId)
        {
            var memberContact = new MemberContact
            {
                Id = _id,
                Phone = _phone,
                Address = _address,
                City = _city,
                MemberId = _memberId
            };
            _dbContext.Add(memberContact);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _phone, string _address, string _city, int _memberId)
        {
            _dbContext.MemberContacts
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Phone, _phone)
                .SetProperty(e => e.Address, _address)
                .SetProperty(e => e.City, _city)
                .SetProperty(e => e.MemberId, _memberId)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.MemberContacts
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
