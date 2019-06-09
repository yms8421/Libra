namespace BilgeAdam.DataTransferObjects.Models
{
    public class BookDTO : BasicDTOBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Author { get; set; }
        public int AuthorId { get; set; }
    }
}
