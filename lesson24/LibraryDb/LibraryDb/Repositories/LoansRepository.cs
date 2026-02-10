using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace LibraryDb.Repositories
{
    public class LoansRepository
    {
        private readonly LibraryDbContext _dbContext;
        public LoansRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, DateOnly _loanDate, DateOnly? _returnDate, DateOnly _dueDate, int _bookId, int _memberId)
        {
            var loan = new Loan
            {
                Id = _id,
                LoanDate = _loanDate,
                ReturnDate = _returnDate,
                DueDate = _dueDate,
                BookId = _bookId,
                MemberId = _memberId
            };
            _dbContext.Add(loan);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, DateOnly _loanDate, DateOnly? _returnDate, DateOnly _dueDate, int _bookId, int _memberId)
        {
            _dbContext.Loans
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.LoanDate, _loanDate)
                .SetProperty(e => e.ReturnDate, _returnDate)
                .SetProperty(e => e.DueDate, _dueDate)
                .SetProperty(e => e.BookId, _bookId)
                .SetProperty(e => e.MemberId, _memberId)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Loans
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
