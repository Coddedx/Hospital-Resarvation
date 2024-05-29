using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Appointment :BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }


        [Required]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }


        [Required]
        public DateTime DateTime { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
