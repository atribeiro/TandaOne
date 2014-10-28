using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TandaOne.Controllers
{
   
    public class TandaHistoryController : Controller
    {
        private EmployeeEntities2 db = new EmployeeEntities2();

    
        public ActionResult Index()
        {
            List<EmployeeDetail> employee = db.EmployeeDetails.ToList();
            return View(employee);
        }

        //public ActionResult Details(int id = 0)
        //{
        //    EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
        //    if (employeedetail == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeedetail);
        //}


        //public ActionResult Create(int id = 0)
        //{
        //    EmployeeDetail Surname = db.EmployeeDetails.Find(id);
        //    return View();
        //}

        //[Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(EmployeeDetail employeedetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.EmployeeDetails.Add(employeedetail);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(employeedetail);
        //}

        //[Authorize]
        //public ActionResult Edit(int id = 0)
        //{
        //    EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
        //    if (employeedetail == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeedetail);
        //}

        //[Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(EmployeeDetail employeedetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(employeedetail).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employeedetail);
        //}


        //[Authorize]
        //public ActionResult Delete(int id = 0)
        //{
        //    EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
        //    if (employeedetail == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employeedetail);
        //}


        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    EmployeeDetail employeedetail = db.EmployeeDetails.Find(id);
        //    db.EmployeeDetails.Remove(employeedetail);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}