namespace AuthorBook.Entities
{
	public class Author : BaseEntity
	{
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
