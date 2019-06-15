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
    public class ЖанрыController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Жанры
        public ActionResult Index()
        {
            return View(db.Жанры.ToList());
        }

        // GET: Жанры/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Жанры жанры = db.Жанры.Find(id);
            if (жанры == null)
            {
                return HttpNotFound();
            }
            return View(жанры);
        }

        // GET: Жанры/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Жанры/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_жанра,Жанр")] Жанры жанры)
        {
            if (ModelState.IsValid)
            {
                db.Жанры.Add(жанры);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(жанры);
        }

        // GET: Жанры/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Жанры жанры = db.Жанры.Find(id);
            if (жанры == null)
            {
                return HttpNotFound();
            }
            return View(жанры);
        }

        // POST: Жанры/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_жанра,Жанр")] Жанры жанры)
        {
            if (ModelState.IsValid)
            {
                db.Entry(жанры).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(жанры);
        }

        // GET: Жанры/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Жанры жанры = db.Жанры.Find(id);
            if (жанры == null)
            {
                return HttpNotFound();
            }
            return View(жанры);
        }

        // POST: Жанры/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Жанры жанры = db.Жанры.Find(id);
            db.Жанры.Remove(жанры);
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
