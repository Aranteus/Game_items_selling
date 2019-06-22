using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Game_items_selling_web.Controllers.DBControllers;
using Game_items_selling_web.Models;

namespace Game_items_selling_web.Controllers
{
    public class СтраныController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Страны
        public ActionResult Index()
        {
            return View(db.Страны.ToList());
        }

        // GET: Страны/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Страны страны = db.Страны.Find(id);
            if (страны == null)
            {
                return HttpNotFound();
            }
            return View(страны);
        }

        // GET: Страны/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Страны/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Буквенный_код_страны,Страна")] Страны страны)
        {
            if (ModelState.IsValid)
            {
                db.Страны.Add(страны);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(страны);
        }

        // GET: Страны/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Страны страны = db.Страны.Find(id);
            if (страны == null)
            {
                return HttpNotFound();
            }
            return View(страны);
        }

        // POST: Страны/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Буквенный_код_страны,Страна")] Страны страны)
        {
            if (ModelState.IsValid)
            {
                db.Entry(страны).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(страны);
        }

        // GET: Страны/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Страны страны = db.Страны.Find(id);
            if (страны == null)
            {
                return HttpNotFound();
            }
            return View(страны);
        }

        // POST: Страны/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Страны страны = db.Страны.Find(id);
            db.Страны.Remove(страны);
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
        public ActionResult Excel()
        {
            System.Data.DataTable list = new System.Data.DataTable();
            for (int i = 0; i < 6; i++)
            { list.Columns.Add(); }
            foreach (Страны country in db.Страны)
            {
                list.Rows.Add(
                    country.Буквенный_код_страны,
                    country.Страна,
                    country.Издатели.Count,
                    country.Торговые_площадки.Count);
            }
            Functions.Excel("countries", list);
            return RedirectToAction("Index");
        }
    }
}
