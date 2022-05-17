namespace FaceyPhotos.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Cost { get; set; }
        public int Quantity { get; set; }
        public string? Details { get; set; }
        public string? SKU { get; set; }
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime Updated { get; set; }

    }
}
