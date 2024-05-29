using HospitalResarvation.Web.Areas.Management.ViewModels;
using HospitalResarvation.Web.Models;
using HospitalResarvation.Web.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.Linq;
using System.Numerics;

namespace HospitalResarvation.Web.Areas.Management.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IWebHostEnvironment _environment;  

        HospitalDbContext db = new HospitalDbContext();  //---------------önceden
        //private readonly HospitalDbContext _context;
        // GET: DoctorController

        public DoctorController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public ActionResult Index()
        {
            // 
            var doctor = db.Doctors
             .Include("Department")
             .Where(c => c.Deleted == false)
             .ToList();
                return View(doctor);
        }



        // GET: DoctorController/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", null);

            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctor model)   //    CreateDoctorViewModel doctorVM
        {
            try
            {
                foreach (var error in ViewData.ModelState.Values.SelectMany(modelState => modelState.Errors))
                { }
                
                if (ModelState.IsValid)
                {
                    model.Status = true;
                    model.CreatedDate = DateTime.Now;
                    model.CreatedBy = 0;
                    model.Deleted = false;

                    var doctor = new Doctor
                    {
                        Paycheck = model.Paycheck
                    };
                    db.Doctors.Add(model);
                    db.SaveChanges();


                    var salary = new Salary
                    {
                        PersonId = model.Id,
                        DepartmentId = model.DepartmentId,
                        Paycheck = model.Paycheck
                    };
                    db.Salaries.Add(salary);
                    db.SaveChanges();


                    return RedirectToAction(nameof(Index));
                }

                ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", model.DepartmentId);
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            var doctor = db.Doctors.Find(id);
            ViewBag.DepartmentId = new SelectList(db.Departments
                   , "Id", "Title", doctor.DepartmentId);
            if (doctor == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }


		// POST: DoctorController/Edit/5
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Doctor model, IFormFile? img)
        {
            try
            {
                if (ModelState.IsValid )
                {
                    var editDoctor = db.Doctors.Find(model.Id);

                    if (img != null)
                    {
                        editDoctor.ImageUrl = await ImageUploader.UploadImageAsync(_environment, img);
                    }
                    if (editDoctor == null)
                    {
						return RedirectToAction(nameof(Index));
						//return View(model);
					}

					var editSalary = db.Salaries.FirstOrDefault(c => c.PersonId == editDoctor.Id && c.DepartmentId == editDoctor.DepartmentId);

                    editDoctor.UpdatedDate = DateTime.Now;
                    editDoctor.UpdatedBy = 0;
                    editDoctor.Status = model.Status;
                    editDoctor.DepartmentId = model.DepartmentId;
                    editDoctor.Paycheck = model.Paycheck;               
                    editDoctor.Title = model.Title;               
                    editDoctor.FirstName = model.FirstName;               
                    editDoctor.LastName = model.LastName;               
                    editDoctor.Email = model.Email;               
                    editDoctor.Phone = model.Phone;               
                    editDoctor.Adress = model.Adress;


                    editSalary.Paycheck = editDoctor.Paycheck;
                    editSalary.DepartmentId = editDoctor.DepartmentId; //kişinin departmanı da değişmiş olabilir

                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }                
                ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", model.DepartmentId);

                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", null);

            var doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var doctor = db.Doctors.Find(id);
                if (doctor == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                doctor.Deleted = true;
                doctor.Status = false;
                doctor.UpdatedDate = DateTime.Now;
                doctor.UpdatedBy = 0;
                db.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
