using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoAvanzada.DAL;
using ProyectoAvanzada.Models;

namespace ProyectoAvanzada.Controllers
{
    public class UMedidasController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: UMedidas
        public ActionResult Index()
        {
            return View(db.UMedidas.ToList());
        }

        // GET: UMedidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UMedida uMedida = db.UMedidas.Find(id);
            if (uMedida == null)
            {
                return HttpNotFound();
            }
            return View(uMedida);
        }

        // GET: UMedidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UMedidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUMedida,Nombre")] UMedida uMedida)
        {
            if (ModelState.IsValid)
            {
                db.UMedidas.Add(uMedida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uMedida);
        }

        // GET: UMedidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UMedida uMedida = db.UMedidas.Find(id);
            if (uMedida == null)
            {
                return HttpNotFound();
            }
            return View(uMedida);
        }

        // POST: UMedidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUMedida,Nombre")] UMedida uMedida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uMedida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uMedida);
        }

        // GET: UMedidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UMedida uMedida = db.UMedidas.Find(id);
            if (uMedida == null)
            {
                return HttpNotFound();
            }
            return View(uMedida);
        }

        // POST: UMedidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UMedida uMedida = db.UMedidas.Find(id);
            db.UMedidas.Remove(uMedida);
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
