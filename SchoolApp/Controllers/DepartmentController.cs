using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Models;

namespace ShoolApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDb departmentDb;
        public DepartmentController(IDepartmentDb departmentDb) 
        { 
            this.departmentDb = departmentDb;
        }

        // GET: DepartmentController
        public ActionResult Index()
        {
            var departments = this.departmentDb.GetDepartments();
            return View(departments);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentAddModel departmentAdd)
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

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentUpdateModel updateModel)
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
