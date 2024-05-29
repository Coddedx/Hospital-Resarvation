using HospitalResarvation.Web.Areas.Management.ViewModels;
using HospitalResarvation.Web.IRepository;
using HospitalResarvation.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using NuGet.Versioning;

namespace HospitalResarvation.Web.Areas.Management.Controllers
{
	public class AppointmentController : Controller
	{
        HospitalDbContext db = new HospitalDbContext();  
		private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
			_appointmentRepository = appointmentRepository;
		}

        // GET: AppointmentController
        public ActionResult Index()
		{
            var appointment = db.Appointments
             .Include(b => b.Patient)
			 .Include(c => c.Doctor)
			 .ThenInclude(d => d.Department)
			 .Where(a => a.Deleted == false)
             .ToList();
            return View(appointment);
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
		{
			return View();
		}

		// GET: AppointmentController/Create
		public async Task<IActionResult> Create(PatientViewModel patientVM)
		{
            ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName", "Department");

			return View(); 
		}

		// POST: AppointmentController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Appointment model, string? searchString, IFormCollection fc, PatientViewModel patientVM) 
		//The FormCollection class will automatically receive the posted form values in the controller action method in key/value pairs. 
		{
			try
			{
                //foreach (var error in ViewData.ModelState.Values.SelectMany(modelState => modelState.Errors))
                //{ }

				//To be able to understand which button is clicked
				var action = fc["action"];
				if (action == "search")
				{
					//Patient View Model e aratılan tc ile gelen veriler ekleniyor
					var AllPatient = _appointmentRepository.GetAllPatientAsync();
					if (!String.IsNullOrEmpty(searchString))
					{
						AllPatient = AllPatient.Where(n => n.Tc.Contains(searchString));
					}
					var SearchedPatient = AllPatient.ToList();

					if ((AllPatient != null) && AllPatient.Any()==true )
					{
						AppointmentViewModel appointmentViewModel = new AppointmentViewModel
						{
							PatientId = SearchedPatient.First().Id,
							PatientFirstName = SearchedPatient.First().FirstName,
							PatientLastName = SearchedPatient.First().LastName,
							PatientTc = SearchedPatient.First().Tc,
							PatientPhone = SearchedPatient.First().Phone,
							PatientAdress = SearchedPatient.First().Adress
						};

						return View(appointmentViewModel);
					}
					//ViewBag.CurPatient = SearchedPatient;  //hoca create de @ ile kullandığı için gerek kalmadı???????????
					return View();
				}


				if (action == "create")
				{
					if (ModelState.IsValid)
					{
						model.Status = true;
						model.CreatedDate = DateTime.Now;
						model.CreatedBy = 0;
						model.Deleted = false;


						//var addPatient = db.Patients.FirstOrDefault(c => c.Tc == addPatient.Tc);


						var addPatient = db.Patients.FirstOrDefault(model.Patient);

						//bool isValid = !this.db.Patients.ToList().Exists(p => p.Tc.Equals(Patient.Tc, StringComparison.CurrentCultureIgnoreCase));


						if (addPatient == null) //hasta veri tabanında yoksa oluşturuluyor
						{
							var patient = new Patient
							{
								FirstName = model.Patient.FirstName,
								LastName = model.Patient.LastName,
								Tc = model.Patient.Tc,
								Phone = model.Patient.Phone,
								Adress = model.Patient.Adress,
								Status = true,
								CreatedDate = DateTime.Now,
								CreatedBy = model.CreatedBy = 0,
								Deleted = model.Deleted = false
							};
							db.Patients.Add(patient);
							db.SaveChanges();
							return RedirectToAction(nameof(Index));
						}

						return RedirectToAction(nameof(Index));
					}

				}

				//ViewBag.PatientId = new SelectList(db.Patients, "Id", "Tc" ,model.PatientId);
				ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName", "Department");

                return View();
            }
            catch
			{
				return View(model);
			}
		}

		// GET: AppointmentController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: AppointmentController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: AppointmentController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: AppointmentController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
