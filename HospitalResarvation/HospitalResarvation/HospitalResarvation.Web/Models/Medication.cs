using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Medication : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}
