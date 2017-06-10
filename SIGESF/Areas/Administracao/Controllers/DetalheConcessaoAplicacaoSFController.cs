using System;
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
    public class DetalheConcessaoAplicacaoSFController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: DetalheConcessaoAplicacaoSF
        public ActionResult Index()
        {
            var detalhesSF = db.DetalhesSF.Include(d => d.ConcessaoSuprimentoFundos).Include(d => d.NaturezasDespesas);
            return View(detalhesSF.ToList());
        }

        // GET: DetalheConcessaoAplicacaoSF/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF = db.DetalhesSF.Find(id);
            if (detalheConcessaoAplicacaoSF == null)
            {
                return HttpNotFound();
            }
            return View(detalheConcessaoAplicacaoSF);
        }

        // GET: DetalheConcessaoAplicacaoSF/Create
        public ActionResult Create()
        {
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.ConcessoesSF, "ConcessaoSuprimentoFundosId", "Proc_Proad");
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao");
            return View();
        }

        // POST: DetalheConcessaoAplicacaoSF/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetConcAplicId,ConcessaoSuprimentoFundosId,NaturezaDespesaId,ValorConcedido,ValorAplicado,DevolucaoSaque,ValorNaoUtilizado")] DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF)
        {
            if (ModelState.IsValid)
            {
                db.DetalhesSF.Add(detalheConcessaoAplicacaoSF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.ConcessoesSF, "ConcessaoSuprimentoFundosId", "Proc_Proad", detalheConcessaoAplicacaoSF.ConcessaoSuprimentoFundosId);
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheConcessaoAplicacaoSF.NaturezaDespesaId);
            return View(detalheConcessaoAplicacaoSF);
        }

        // GET: DetalheConcessaoAplicacaoSF/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF = db.DetalhesSF.Find(id);
            if (detalheConcessaoAplicacaoSF == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.ConcessoesSF, "ConcessaoSuprimentoFundosId", "Proc_Proad", detalheConcessaoAplicacaoSF.ConcessaoSuprimentoFundosId);
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheConcessaoAplicacaoSF.NaturezaDespesaId);
            return View(detalheConcessaoAplicacaoSF);
        }

        // POST: DetalheConcessaoAplicacaoSF/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetConcAplicId,ConcessaoSuprimentoFundosId,NaturezaDespesaId,ValorConcedido,ValorAplicado,DevolucaoSaque,ValorNaoUtilizado")] DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalheConcessaoAplicacaoSF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.ConcessoesSF, "ConcessaoSuprimentoFundosId", "Proc_Proad", detalheConcessaoAplicacaoSF.ConcessaoSuprimentoFundosId);
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheConcessaoAplicacaoSF.NaturezaDespesaId);
            return View(detalheConcessaoAplicacaoSF);
        }

        // GET: DetalheConcessaoAplicacaoSF/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF = db.DetalhesSF.Find(id);
            if (detalheConcessaoAplicacaoSF == null)
            {
                return HttpNotFound();
            }
            return View(detalheConcessaoAplicacaoSF);
        }

        // POST: DetalheConcessaoAplicacaoSF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalheConcessaoAplicacaoSF detalheConcessaoAplicacaoSF = db.DetalhesSF.Find(id);
            db.DetalhesSF.Remove(detalheConcessaoAplicacaoSF);
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
