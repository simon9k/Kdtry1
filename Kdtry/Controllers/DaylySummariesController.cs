using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kdtry.DAL;
using Kdtry.Models;

namespace Kdtry.Controllers
{
    public class DaylySummariesController : Controller
    {
        private KdtryContext db = new KdtryContext();

        // GET: DaylySummaries
        public ActionResult Index()
        {
            return View(db.DaylySummaries.ToList());
        }

        // GET: DaylySummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaylySummary daylySummary = db.DaylySummaries.Find(id);
            if (daylySummary == null)
            {
                return HttpNotFound();
            }
            return View(daylySummary);
        }

        // GET: DaylySummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DaylySummaries/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DaylySummaryID,PupilID,Credits,Summary")] DaylySummary daylySummary)
        {
            if (ModelState.IsValid)
            {
                db.DaylySummaries.Add(daylySummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(daylySummary);
        }

        // GET: DaylySummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaylySummary daylySummary = db.DaylySummaries.Find(id);
            if (daylySummary == null)
            {
                return HttpNotFound();
            }
            return View(daylySummary);
        }

        // POST: DaylySummaries/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DaylySummaryID,PupilID,Credits,Summary")] DaylySummary daylySummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daylySummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daylySummary);
        }

        // GET: DaylySummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaylySummary daylySummary = db.DaylySummaries.Find(id);
            if (daylySummary == null)
            {
                return HttpNotFound();
            }
            return View(daylySummary);
        }

        // POST: DaylySummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DaylySummary daylySummary = db.DaylySummaries.Find(id);
            db.DaylySummaries.Remove(daylySummary);
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
