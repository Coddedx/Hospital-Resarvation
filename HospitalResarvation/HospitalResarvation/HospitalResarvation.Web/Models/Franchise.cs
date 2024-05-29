using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Franchise
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int HospiatlId { get; set; }
        [ForeignKey("HospiatlId")]
        public virtual Hospital Hospital { get; set; }


        [Required]
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }


        [Required, StringLength(64)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(128)]
        public string Address { get; set; }

        [StringLength(128)]
        public string? ImageUrl { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }
        [Required, StringLength(13)]
        public string Phone { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
