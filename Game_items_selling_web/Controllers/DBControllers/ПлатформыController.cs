using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Game_items_selling_web.Models;

namespace Game_items_selling_web.Controllers
{
    public class ПлатформыController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Платформы
        public ActionResult Index()
        {
            return View(db.Платформы.ToList());
        }

        // GET: Платформы/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Платформы платформы = db.Платформы.Find(id);
            if (платформы == null)
            {
                return HttpNotFound();
            }
            return View(платформы);
        }

        // GET: Платформы/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Платформы/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_платформы,Платформа")] Платформы платформы)
        {
            if (ModelState.IsValid)
            {
                db.Платформы.Add(платформы);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(платформы);
        }

        // GET: Платформы/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Платформы платформы = db.Платформы.Find(id);
            if (платформы == null)
            {
                return HttpNotFound();
            }
            return View(платформы);
        }

        // POST: Платформы/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_платформы,Платформа")] Платформы платформы)
        {
            if (ModelState.IsValid)
            {
                db.Entry(платформы).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(платформы);
        }

        // GET: Платформы/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Платформы платформы = db.Платформы.Find(id);
            if (платформы == null)
            {
                return HttpNotFound();
            }
            return View(платформы);
        }

        // POST: Платформы/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Платформы платформы = db.Платформы.Find(id);
            db.Платформы.Remove(платформы);
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
