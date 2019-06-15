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
    public class ВалютыController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Валюты
        public ActionResult Index()
        {
            return View(db.Валюты.ToList());
        }

        // GET: Валюты/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Валюты валюты = db.Валюты.Find(id);
            if (валюты == null)
            {
                return HttpNotFound();
            }
            return View(валюты);
        }

        // GET: Валюты/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Валюты/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Буквенный_код_валюты,Валюта")] Валюты валюты)
        {
            if (ModelState.IsValid)
            {
                db.Валюты.Add(валюты);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(валюты);
        }

        // GET: Валюты/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Валюты валюты = db.Валюты.Find(id);
            if (валюты == null)
            {
                return HttpNotFound();
            }
            return View(валюты);
        }

        // POST: Валюты/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Буквенный_код_валюты,Валюта")] Валюты валюты)
        {
            if (ModelState.IsValid)
            {
                db.Entry(валюты).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(валюты);
        }

        // GET: Валюты/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Валюты валюты = db.Валюты.Find(id);
            if (валюты == null)
            {
                return HttpNotFound();
            }
            return View(валюты);
        }

        // POST: Валюты/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Валюты валюты = db.Валюты.Find(id);
            db.Валюты.Remove(валюты);
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
