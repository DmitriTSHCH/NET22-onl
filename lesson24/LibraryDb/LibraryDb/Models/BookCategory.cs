namespace LibraryDb.Models
{
    public class BookCategory
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public DateOnly AddedDate { get; set; }
    }
}
