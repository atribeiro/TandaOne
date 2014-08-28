using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TandaOne.Controllers
{
    public class TandaHistoryController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        //
        // GET: /TandaHistory/

        public ActionResult Index()
        {
            return View(db.EmployeeDetails.ToList());
        }

        //
        // GET: /TandaHistory/Details/5

        public ActionResult Details(int id = 0)
        {
            EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
            if (employeedetail == null)
            {
                return HttpNotFound();
            }
            return View(employeedetail);
        }

        //
        // GET: /TandaHistory/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TandaHistory/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeDetail employeedetail)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDetails.Add(employeedetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeedetail);
        }

        //
        // GET: /TandaHistory/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
            if (employeedetail == null)
            {
                return HttpNotFound();
            }
            return View(employeedetail);
        }

        //
        // POST: /TandaHistory/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeDetail employeedetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeedetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeedetail);
        }

        //
        // GET: /TandaHistory/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
            if (employeedetail == null)
            {
                return HttpNotFound();
            }
            return View(employeedetail);
        }

        //
        // POST: /TandaHistory/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
            db.EmployeeDetails.Remove(employeedetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}