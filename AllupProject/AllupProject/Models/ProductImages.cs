namespace AllupProject.Models
{
    public class ProductImages:BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool? IsPrimary { get; set; }

        //relational
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
