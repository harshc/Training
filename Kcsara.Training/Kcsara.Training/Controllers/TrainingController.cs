using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kcsara.Training.Models;

namespace Kcsara.Training.Controllers
{
    public class TrainingController : Controller
    {
        private AuthDatabaseEntities db = new AuthDatabaseEntities();

        // GET: /Training/
        public ActionResult Index()
        {
            var members = db.Members.Include(m => m.MemberMedical);
            return View(members.ToList());
        }

        // Training landing page for the user
        public ActionResult Home()
        {

        }

        // GET: /Training/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: /Training/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.MemberMedicals, "Id", "EncryptedAllergies");
            return View();
        }

        // POST: /Training/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,DEM,LastName,FirstName,MiddleName,PhotoFile,Username,BackgroundDate,SheriffApp,Status")] Member member)
        {
            if (ModelState.IsValid)
            {
                member.Id = Guid.NewGuid();
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.MemberMedicals, "Id", "EncryptedAllergies", member.Id);
            return View(member);
        }

        // GET: /Training/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.MemberMedicals, "Id", "EncryptedAllergies", member.Id);
            return View(member);
        }

        // POST: /Training/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,DEM,LastName,FirstName,MiddleName,InternalBirthDate,InternalGender,PhotoFile,InternalWacLevel,WacLevelDate,Username,Comments,BackgroundDate,SheriffApp,ExternalKey1,Status,LastChanged,ChangedBy")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.MemberMedicals, "Id", "EncryptedAllergies", member.Id);
            return View(member);
        }

        // GET: /Training/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: /Training/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Member member = db.Members.Find(id);
            db.Members.Remove(member);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
