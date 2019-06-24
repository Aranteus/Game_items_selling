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
    public class Торговые_площадкиController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Торговые_площадки
        public ActionResult Index()
        {
            var торговые_площадки = db.Торговые_площадки.Include(т => т.Страны);
            return View(торговые_площадки.ToList());
        }

        // GET: Торговые_площадки/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Торговые_площадки торговые_площадки = db.Торговые_площадки.Find(id);
            if (торговые_площадки == null)
            {
                return HttpNotFound();
            }
            return View(торговые_площадки);
        }

        // GET: Торговые_площадки/Create
        public ActionResult Create(string _role = "create")
        {
            ViewBag.role = _role;
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна");
            return View();
        }

        // POST: Торговые_площадки/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_торговой_площадки,Торговая_площадка,Дата_создания,Код_страны")] Торговые_площадки торговые_площадки, string _role = "create")
        {
            if (ModelState.IsValid)
            {
                db.Торговые_площадки.Add(торговые_площадки);
                db.SaveChanges();
                if (_role == "register") return RedirectToAction("Register", "Home", new
                {
                    login = торговые_площадки.Код_торговой_площадки.ToString() + "_" + торговые_площадки.Торговая_площадка.ToString(),
                    password = "trader"
                });
                else
                    return RedirectToAction("Index");
            }

            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", торговые_площадки.Код_страны);
            return View(торговые_площадки);
        }

        // GET: Торговые_площадки/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Торговые_площадки торговые_площадки = db.Торговые_площадки.Find(id);
            if (торговые_площадки == null)
            {
                return HttpNotFound();
            }
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", торговые_площадки.Код_страны);
            return View(торговые_площадки);
        }

        // POST: Торговые_площадки/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_торговой_площадки,Торговая_площадка,Дата_создания,Код_страны")] Торговые_площадки торговые_площадки)
        {
            if (ModelState.IsValid)
            {
                db.Entry(торговые_площадки).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Код_страны = new SelectList(db.Страны, "Буквенный_код_страны", "Страна", торговые_площадки.Код_страны);
            return View(торговые_площадки);
        }

        // GET: Торговые_площадки/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Торговые_площадки торговые_площадки = db.Торговые_площадки.Find(id);
            if (торговые_площадки == null)
            {
                return HttpNotFound();
            }
            return View(торговые_площадки);
        }

        // POST: Торговые_площадки/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Торговые_площадки торговые_площадки = db.Торговые_площадки.Find(id);
            db.Торговые_площадки.Remove(торговые_площадки);
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
            foreach (Торговые_площадки trade in db.Торговые_площадки)
            {
                list.Rows.Add(
                    trade.Код_торговой_площадки,
                    trade.Торговая_площадка,
                    trade.Дата_создания,
                    trade.Страны.Страна,
                    trade.Чек.Count);
            }
            Functions.Excel("traders", list);
            return RedirectToAction("Index");
        }
    }
}
