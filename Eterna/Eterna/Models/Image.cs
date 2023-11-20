namespace Eterna.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
