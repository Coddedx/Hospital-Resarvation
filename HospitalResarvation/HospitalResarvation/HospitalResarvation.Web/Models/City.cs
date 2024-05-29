using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace HospitalResarvation.Web.Models
{
    public class City 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }


        [Required, StringLength(64)]
        public string Name { get; set; }
    }
}
