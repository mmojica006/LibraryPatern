using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;

        }
        // GET: Department
        public ActionResult Index()
        {
            IEnumerable<DepartmentModel> dept = departmentService.GetDeparments().Select(u => new DepartmentModel
            {
                ID = u.ID,
                Name = u.Name
            });


            return View(dept);
        }
    }
}