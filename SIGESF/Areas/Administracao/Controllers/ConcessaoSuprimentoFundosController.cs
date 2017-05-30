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
    public class ConcessaoSuprimentoFundosController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: ConcessaoSuprimentoFundos
        public ActionResult Index()
        {
            var concessoes = db.ConcessoesSF.Include(c => c.AgenteSuprido);
            return View(concessoes.ToList());
        }

        // GET: ConcessaoSuprimentoFundos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConcessaoSuprimentoFundos concessaoSuprimentoFundos = db.ConcessoesSF.Find(id);
            if (concessaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(concessaoSuprimentoFundos);
        }

        // GET: ConcessaoSuprimentoFundos/Create
        public ActionResult Create()
        {
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome");
            return View();
        }

        // POST: ConcessaoSuprimentoFundos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConcessaoSuprimentoFundosId,AgenteSupridoId,PrazoAplicacao,PrestadoContas")] ConcessaoSuprimentoFundos concessaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.ConcessoesSF.Add(concessaoSuprimentoFundos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", concessaoSuprimentoFundos.AgenteSupridoId);
            return View(concessaoSuprimentoFundos);
        }

        // GET: ConcessaoSuprimentoFundos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConcessaoSuprimentoFundos concessaoSuprimentoFundos = db.ConcessoesSF.Find(id);
            if (concessaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", concessaoSuprimentoFundos.AgenteSupridoId);
            return View(concessaoSuprimentoFundos);
        }

        // POST: ConcessaoSuprimentoFundos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConcessaoSuprimentoFundosId,AgenteSupridoId,PrazoAplicacao,PrestadoContas")] ConcessaoSuprimentoFundos concessaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(concessaoSuprimentoFundos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", concessaoSuprimentoFundos.AgenteSupridoId);
            return View(concessaoSuprimentoFundos);
        }

        // GET: ConcessaoSuprimentoFundos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConcessaoSuprimentoFundos concessaoSuprimentoFundos = db.ConcessoesSF.Find(id);
            if (concessaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(concessaoSuprimentoFundos);
        }

        // POST: ConcessaoSuprimentoFundos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConcessaoSuprimentoFundos concessaoSuprimentoFundos = db.ConcessoesSF.Find(id);
            db.ConcessoesSF.Remove(concessaoSuprimentoFundos);
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