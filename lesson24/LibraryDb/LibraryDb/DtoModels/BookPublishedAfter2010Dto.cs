namespace LibraryDb.DtoModels
{
    public class BookPublishedAfter2010Dto
    {
        public string Title { get; set; }
        public DateOnly PublicationYear { get; set; }
        public string AuthorName { get; set; }
    }
}
