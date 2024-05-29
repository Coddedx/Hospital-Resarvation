using HospitalResarvation.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Areas.Management.ViewModels
{
	public class AppointmentViewModel
    {
        [Key]
        public int Id { get; set; }

        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientTc { get; set; }
        public string PatientPhone { get; set; }
        public string PatientAdress { get; set; }


		public int DoctorId { get; set; }
		public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorDepartment { get; set; }
        public string DoctorEmail { get; set; }

        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }

        //public List<Patient> Patients { get; set; }
        //public List<Doctor> Doctors { get; set; }
        //public List<Appointment> Appointments { get; set; }

    }
}
