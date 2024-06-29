using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_MVC_CRUD.Controllers
{
    public class Employee : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

    }
}
