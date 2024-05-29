using HospitalResarvation.Web.Areas.Management.ViewModels;
using HospitalResarvation.Web.Models;

namespace HospitalResarvation.Web.IRepository
{
	public interface IAppointmentRepository
	{
		IQueryable<PatientViewModel> GetAllPatientAsync();
	}
}
