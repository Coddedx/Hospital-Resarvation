using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Patient : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Tc { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Adress { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
