using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Salary : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public decimal Paycheck { get; set; }

        public int PersonId { get; set; }  // staff/doctor ıd si buraya gelicek
        public int DepartmentId { get; set; }  //departman ı da buraya gelcek ki maaş kimin anlayabilelim (doktorla staff karışmasın diye )

        //public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Staff> Staffs { get; set; }



    }
}
