using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalResarvation.Web.Models
{
    public class Staff : BaseEntity
    {
        [Key]   
        public int Id { get; set; }


        [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


        [Required]
        public int SalaryId { get; set; }
        [ForeignKey("SalaryId")]
        public virtual Salary Salary { get; set; }


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

        //public ICollection<Room> Room { get; set; }

    }
}
