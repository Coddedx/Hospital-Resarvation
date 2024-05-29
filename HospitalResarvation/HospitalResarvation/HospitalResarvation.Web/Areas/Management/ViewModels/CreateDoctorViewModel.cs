using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Areas.Management.ViewModels
{
	public class CreateDoctorViewModel
	{
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
        public decimal Paycheck { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }
}
