using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalResarvation.Web.Models
{
    public class Prescription : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        //medication da eklicez fr
        [Required]
        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public virtual Medication Medicaiton { get; set; }


        public DateTime PrescriptionDate { get; set; }
    }
}
