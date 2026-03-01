namespace LibraryDb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateOnly PublicationYear { get; set; }
        public float Price { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
