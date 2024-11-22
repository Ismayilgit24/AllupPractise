namespace AllupProject.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal ExTax { get; set; }
        public string ProductCode { get; set; }
        public string Availability { get; set; }

        //relational

        public int CategoryId { get; set; }
        public Category category { get; set; }
        public List<ProductImages> ProductImages { get; set; }

    }
}
