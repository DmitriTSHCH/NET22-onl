namespace LibraryDb.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateOnly LoanDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
    }
}
