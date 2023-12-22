﻿namespace BookStoreAPI.Entities
{
	public class Book : BaseEntity
	{
        public string Name { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
