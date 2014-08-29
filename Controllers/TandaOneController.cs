using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TandaOne.Models;

namespace TandaOne.Controllers
{
    public class TandaOneController : Controller
    {
        private EmployeeEntities2 db = new EmployeeEntities2();
        
        public ActionResult Index()
        {

            List<EmployeeDetail> employee = db.EmployeeDetails.ToList();

            return View(employee);
        }


        //public ActionResult Details(int id = 0)
        //{

        //    trackinghour trackinghour = db.trackinghours.Find(id);
        //    if (trackinghour == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(trackinghour);
        //}

        
         //GET: /TandaOne/Create

        public ActionResult Create()
        {
            return View();
        }

        
         //POST: /TandaOne/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(trackinghour trackinghour)
        {
            if (ModelState.IsValid)
            {
                db.trackinghours.Add(trackinghour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trackinghour);
        }

        
         //GET: /TandaOne/Edit/5

        public ActionResult Edit(int id = 0)
        {
            trackinghour trackinghour = db.trackinghours.Find(id);
            if (trackinghour == null)
            {
                return HttpNotFound();
            }
            return View(trackinghour);
        }

        
         //POST: /TandaOne/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(trackinghour trackinghour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trackinghour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trackinghour);
        }

        
         //GET: /TandaOne/Delete/5

        public ActionResult Delete(int id = 0)
        {
            trackinghour trackinghour = db.trackinghours.Find(id);
            if (trackinghour == null)
            {
                return HttpNotFound();
            }
            return View(trackinghour);
        }

        
         //POST: /TandaOne/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            trackinghour trackinghour = db.trackinghours.Find(id);
            db.trackinghours.Remove(trackinghour);
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