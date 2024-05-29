using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalResarvation.Web.Models
{
    public class Doctor :BaseEntity
    {
        [Key]
        public int Id { get; set; }


        //---------önceden [ForeignKey("DepartmentId")]
        [Required]
        public int DepartmentId { get; set; } //---------önceden  string
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; } //---------önceden virtual


        [Required]
        public decimal Paycheck { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
       
        [Required]
        public string Email { get; set; }


        [Required]
        public string Phone { get; set; }

        [Required]
        public string Adress { get; set; }

        //[Required, DefaultValue(true)]
        //public bool Status { get; set; }

        public string? ImageUrl { get; set; } //fitness denemek için eklemitim 


        public ICollection<Appointment?>? Appointments { get; set; } 

    }
}
