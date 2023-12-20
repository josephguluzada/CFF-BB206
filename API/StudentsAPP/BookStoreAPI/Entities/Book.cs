namespace BookStoreAPI.Entities
{
	public class Book : BaseEntity
	{
        public string Name { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }

    }
}
