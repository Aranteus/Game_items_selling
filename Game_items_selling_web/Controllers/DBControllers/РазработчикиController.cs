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
    public class РазработчикиController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Разработчики
        public ActionResult Index()
        {
            return View(db.Разработчики.ToList());
        }

        // GET: Разработчики/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Разработчики разработчики = db.Разработчики.Find(id);
            if (разработчики == null)
            {
                return HttpNotFound();
            }
            return View(разработчики);
        }

        // GET: Разработчики/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Разработчики/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_разработчика,Разработчик,Дата_основания,Кол_во_сотрудников")] Разработчики разработчики)
        {
            if (ModelState.IsValid)
            {
                db.Разработчики.Add(разработчики);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(разработчики);
        }

        // GET: Разработчики/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Разработчики разработчики = db.Разработчики.Find(id);
            if (разработчики == null)
            {
                return HttpNotFound();
            }
            return View(разработчики);
        }

        // POST: Разработчики/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_разработчика,Разработчик,Дата_основания,Кол_во_сотрудников")] Разработчики разработчики)
        {
            if (ModelState.IsValid)
            {
                db.Entry(разработчики).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(разработчики);
        }

        // GET: Разработчики/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Разработчики разработчики = db.Разработчики.Find(id);
            if (разработчики == null)
            {
                return HttpNotFound();
            }
            return View(разработчики);
        }

        // POST: Разработчики/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Разработчики разработчики = db.Разработчики.Find(id);
            db.Разработчики.Remove(разработчики);
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
