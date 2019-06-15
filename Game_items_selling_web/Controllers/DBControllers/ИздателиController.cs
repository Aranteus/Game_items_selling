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
    public class ИздателиController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Издатели
        public ActionResult Index()
        {
            var издатели = db.Издатели.Include(и => и.Страны);
            return View(издатели.ToList());
        }

        // GET: Издатели/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Издатели издатели = db.Издатели.Find(id);
            if (издатели == null)
            {
                return HttpNotFound();
            }
            return View(издатели);
        }

        // GET: Издатели/Create
        public ActionResult Create()
        {
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна");
            return View();
        }

        // POST: Издатели/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_издателя,Издатель,Код_страны")] Издатели издатели)
        {
            if (ModelState.IsValid)
            {
                db.Издатели.Add(издатели);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", издатели.Код_страны);
            return View(издатели);
        }

        // GET: Издатели/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Издатели издатели = db.Издатели.Find(id);
            if (издатели == null)
            {
                return HttpNotFound();
            }
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", издатели.Код_страны);
            return View(издатели);
        }

        // POST: Издатели/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_издателя,Издатель,Код_страны")] Издатели издатели)
        {
            if (ModelState.IsValid)
            {
                db.Entry(издатели).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", издатели.Код_страны);
            return View(издатели);
        }

        // GET: Издатели/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Издатели издатели = db.Издатели.Find(id);
            if (издатели == null)
            {
                return HttpNotFound();
            }
            return View(издатели);
        }

        // POST: Издатели/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Издатели издатели = db.Издатели.Find(id);
            db.Издатели.Remove(издатели);
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
