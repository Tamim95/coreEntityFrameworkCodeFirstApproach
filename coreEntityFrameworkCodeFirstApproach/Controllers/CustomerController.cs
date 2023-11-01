using coreEntityFrameworkCodeFirstApproach.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreEntityFrameworkCodeFirstApproach.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDBContext _context;
        public CustomerController()
        {
            _context = new ApplicationDBContext();
        }

        // GET: CustomerController
        public ActionResult Index()
        {

            var customers=_context.Customers.ToList();
            return View(customers);
            //var customers=_context.Customers.ToList() *** Customers model class picking data using ToList() in _context obj
            // which is object of ApplicationDBContext model class. And all data storing ing customers variable.
            //and Binding this customers variable with return View(customers). and generate a view here.

        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
