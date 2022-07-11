using System.ComponentModel.DataAnnotations;
namespace Codebase_6.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}
