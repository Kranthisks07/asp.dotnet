using System.ComponentModel.DataAnnotations;

namespace MainProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [DataType(DataType.Currency)]
        public float ProductPrice { get; set; }
        public string ProductBrand { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]

        public string ManufactureDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public string ExpirationDate { get; set; }

    }
}
