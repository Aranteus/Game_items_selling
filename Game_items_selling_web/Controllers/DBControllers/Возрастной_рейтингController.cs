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
    public class Возрастной_рейтингController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Возрастной_рейтинг
        public ActionResult Index()
        {
            return View(db.Возрастной_рейтинг.ToList());
        }

        // GET: Возрастной_рейтинг/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Возрастной_рейтинг возрастной_рейтинг = db.Возрастной_рейтинг.Find(id);
            if (возрастной_рейтинг == null)
            {
                return HttpNotFound();
            }
            return View(возрастной_рейтинг);
        }

        // GET: Возрастной_рейтинг/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Возрастной_рейтинг/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_возрастного_рейтинга,Название_рейтинга,Рейтинг")] Возрастной_рейтинг возрастной_рейтинг)
        {
            if (ModelState.IsValid)
            {
                db.Возрастной_рейтинг.Add(возрастной_рейтинг);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(возрастной_рейтинг);
        }

        // GET: Возрастной_рейтинг/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Возрастной_рейтинг возрастной_рейтинг = db.Возрастной_рейтинг.Find(id);
            if (возрастной_рейтинг == null)
            {
                return HttpNotFound();
            }
            return View(возрастной_рейтинг);
        }

        // POST: Возрастной_рейтинг/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_возрастного_рейтинга,Название_рейтинга,Рейтинг")] Возрастной_рейтинг возрастной_рейтинг)
        {
            if (ModelState.IsValid)
            {
                db.Entry(возрастной_рейтинг).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(возрастной_рейтинг);
        }

        // GET: Возрастной_рейтинг/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Возрастной_рейтинг возрастной_рейтинг = db.Возрастной_рейтинг.Find(id);
            if (возрастной_рейтинг == null)
            {
                return HttpNotFound();
            }
            return View(возрастной_рейтинг);
        }

        // POST: Возрастной_рейтинг/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Возрастной_рейтинг возрастной_рейтинг = db.Возрастной_рейтинг.Find(id);
            db.Возрастной_рейтинг.Remove(возрастной_рейтинг);
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
