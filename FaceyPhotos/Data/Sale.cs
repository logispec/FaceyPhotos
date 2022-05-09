
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceyPhotos.Data
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public double price { get; set; }



    }
}
