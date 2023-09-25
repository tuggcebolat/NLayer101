namespace NLayer.Core
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; } //foreignkey

        public Category Category { get; set; } //bir ürünün bir kategorisi olabilir

        public ProductFeature ProductFeature { get; set; }  //bir ürünün özellikleri var
    }
}
