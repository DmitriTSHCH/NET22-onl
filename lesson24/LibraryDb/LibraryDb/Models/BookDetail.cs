namespace LibraryDb.Models
{
    public class BookDetail
    {

        public int Id { get; set; }
        public string Summary { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public int Edition { get; set; }
        public int BookId { get; set; }
    }
}
