namespace AuthorBook.Entities
{
	public class Book : BaseEntity
	{
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
