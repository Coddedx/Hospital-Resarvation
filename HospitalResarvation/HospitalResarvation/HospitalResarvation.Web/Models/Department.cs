using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalResarvation.Web.Models
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public virtual Hospital Hospital { get; set; }

        public ICollection<Doctor> Doctor { get; set; }
        public ICollection<Staff> Staff { get; set; }

    }
}
