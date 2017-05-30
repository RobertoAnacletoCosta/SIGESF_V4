﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIGESF.Models;

namespace Areas.Administracao.Controllers
{
    public class NaturezaDespesaController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: NaturezaDespesa
        public ActionResult Index()
        {
            return View(db.NaturezaDespesa.ToList());
        }

        // GET: NaturezaDespesa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaturezaDespesa naturezaDespesa = db.NaturezaDespesa.Find(id);
            if (naturezaDespesa == null)
            {
                return HttpNotFound();
            }
            return View(naturezaDespesa);
        }

        // GET: NaturezaDespesa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NaturezaDespesa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NaturezaDespesaId,CodigoDespesa,Descricao")] NaturezaDespesa naturezaDespesa)
        {
            if (ModelState.IsValid)
            {
                db.NaturezaDespesa.Add(naturezaDespesa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(naturezaDespesa);
        }

        // GET: NaturezaDespesa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaturezaDespesa naturezaDespesa = db.NaturezaDespesa.Find(id);
            if (naturezaDespesa == null)
            {
                return HttpNotFound();
            }
            return View(naturezaDespesa);
        }

        // POST: NaturezaDespesa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NaturezaDespesaId,CodigoDespesa,Descricao")] NaturezaDespesa naturezaDespesa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(naturezaDespesa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(naturezaDespesa);
        }

        // GET: NaturezaDespesa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaturezaDespesa naturezaDespesa = db.NaturezaDespesa.Find(id);
            if (naturezaDespesa == null)
            {
                return HttpNotFound();
            }
            return View(naturezaDespesa);
        }

        // POST: NaturezaDespesa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NaturezaDespesa naturezaDespesa = db.NaturezaDespesa.Find(id);
            db.NaturezaDespesa.Remove(naturezaDespesa);
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