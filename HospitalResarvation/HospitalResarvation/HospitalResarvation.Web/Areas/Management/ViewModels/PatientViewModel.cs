using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Areas.Management.ViewModels
{
	public class PatientViewModel
	{
		[Key]
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Tc { get; set; }

		public string Phone { get; set; }

		public string Adress { get; set; }


	}
}
