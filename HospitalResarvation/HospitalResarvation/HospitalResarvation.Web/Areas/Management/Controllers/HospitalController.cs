using HospitalResarvation.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalResarvation.Web.Areas.Management.Controllers
{
    public class HospitalController : Controller
    {
        HospitalDbContext db = new HospitalDbContext();

        // GET: HospitalController
        public ActionResult Index()
        {
            var hospital = db.Hospitals.ToList();
            return View(hospital);
        }

        // GET: HospitalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HospitalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hospital model)
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
                    db.Hospitals.Add(model);
                     db.SaveChanges();
                     return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                } 
            }
            catch
            {
                return View(model);
            }
        }

        // GET: HospitalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HospitalController/Edit/5
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

        // GET: HospitalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HospitalController/Delete/5
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
