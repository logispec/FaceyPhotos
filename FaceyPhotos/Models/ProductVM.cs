using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FaceyPhotos.Models;

public class ProductVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public string? SKU { get; set; }
    [Required]
    public string? Details { get; set; }
    public int Quantity { get; set; }
    [Required]
    public float Cost { get; set; }

}






