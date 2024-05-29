using HospitalResarvation.Web.Areas.Management.ViewModels;
using HospitalResarvation.Web.IRepository;
using HospitalResarvation.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalResarvation.Web.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
		private readonly HospitalDbContext _context;

        public AppointmentRepository()//HospitalDbContext context
		{
			_context = new HospitalDbContext();  //program cs de add scoped ekleyemiyodum dependency injection u bu şekilde denedim oldu
        }


		public IQueryable<PatientViewModel> GetAllPatientAsync()
		{
			var patients = _context.Patients
			.Select(e => new PatientViewModel
			{
				Id = e.Id,
				FirstName = e.FirstName,
				LastName = e.LastName,
				Tc = e.Tc,
				Phone = e.Phone,
				Adress = e.Adress
			});
			return patients;
		}


		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public JsonResult AjaxMethod([FromBody] Patient patient)
		//{
		//    bool isValid = !this. _context.Patients.ToList().Exists(p => p.Tc.Equals(patient.Tc, StringComparison.CurrentCultureIgnoreCase));
		//   return Json(isValid);
		//}

	}
}
