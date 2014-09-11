using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TandaOne = TandaOne.Models.TandaOne;

namespace TandaOne.Controllers
{
    public class TandaOneController : Controller
    {
        private EmplSampleEntities db = new EmplSampleEntities();

        //
        // GET: /TandaOne/

        public ActionResult Index()
        {
            return View(db.trackinghours.ToList());
        }

        //
        // GET: /TandaOne/Details/5

        public ActionResult Details(int id = 0)
        {
            trackinghour trackinghour = db.trackinghours.Single(t => t.EmployeeID == id);
            if (trackinghour == null)
            {
                return HttpNotFound();
            }
            return View(trackinghour);
        }

        //
        // GET: /TandaOne/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TandaOne/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(trackinghour trackinghour)
        {
            if (ModelState.IsValid)
            {
                
                var arrival = DateTime.UtcNow;
                trackinghour.Arrival = arrival;

                db.trackinghours.AddObject(trackinghour);
                db.SaveChanges();

                if (trackinghour.Surname != null && trackinghour.Arrival != null)
                {
                    var departure = DateTime.UtcNow;
                    trackinghour.Departure = departure;
                }

                db.trackinghours.AddObject(trackinghour);
                db.SaveChanges();
                
                  return RedirectToAction("Create");
            }

            return View(trackinghour);
        }

        //
        // GET: /TandaOne/Edit/5

        public ActionResult Edit(int id = 0)
        {
            trackinghour trackinghour = db.trackinghours.Single(t => t.EmployeeID == id);
            if (trackinghour == null)
            {
                return HttpNotFound();
            }
            return View(trackinghour);
        }

        //
        // POST: /TandaOne/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(trackinghour trackinghour)
        {
            if (ModelState.IsValid)
            {
                db.trackinghours.Attach(trackinghour);
                db.ObjectStateManager.ChangeObjectState(trackinghour, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trackinghour);
        }

        //
        // GET: /TandaOne/Delete/5

        public ActionResult Delete(int id = 0)
        {
            trackinghour trackinghour = db.trackinghours.Single(t => t.EmployeeID == id);
            if (trackinghour == null)
            {
                return HttpNotFound();
            }
            return View(trackinghour);
        }

        //
        // POST: /TandaOne/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            trackinghour trackinghour = db.trackinghours.Single(t => t.EmployeeID == id);
            db.trackinghours.DeleteObject(trackinghour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public EmployeeDetail employeedetail { get; set; }
    }
}