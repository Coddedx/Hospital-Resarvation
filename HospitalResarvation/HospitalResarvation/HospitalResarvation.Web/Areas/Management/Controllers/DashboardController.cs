using Microsoft.AspNetCore.Mvc;

namespace HospitalResarvation.Web.Areas.Management.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
