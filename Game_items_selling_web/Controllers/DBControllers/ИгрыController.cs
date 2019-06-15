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
    public class ИгрыController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Игры
        public ActionResult Index()
        {
            var игры = db.Игры.Include(и => и.Жанры).Include(и => и.Платформы).Include(и => и.Разработчики);
            return View(игры.ToList());
        }

        // GET: Игры/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            return View(игры);
        }

        // GET: Игры/Create
        public ActionResult Create()
        {
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр");
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа");
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик");
            return View();
        }

        // POST: Игры/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_игры,Код_разработчика,Код_жанра,Код_платформы,Игра,Движок,Дата_создания")] Игры игры)
        {
            if (ModelState.IsValid)
            {
                db.Игры.Add(игры);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // GET: Игры/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // POST: Игры/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_игры,Код_разработчика,Код_жанра,Код_платформы,Игра,Движок,Дата_создания")] Игры игры)
        {
            if (ModelState.IsValid)
            {
                db.Entry(игры).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // GET: Игры/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            return View(игры);
        }

        // POST: Игры/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Игры игры = db.Игры.Find(id);
            db.Игры.Remove(игры);
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
