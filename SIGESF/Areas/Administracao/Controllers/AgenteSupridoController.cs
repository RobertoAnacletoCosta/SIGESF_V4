﻿using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIGESF.Models;
using PagedList;
using System;

namespace Areas.Administracao.Controllers
{
    public class AgenteSupridoController : Controller
    {
        private ContextoEF db = new ContextoEF();

        public ViewResult Index(string sortOrder, string currenteFilter, string searchString, int? page)
        {
            try
            {
                ViewBag.CurrentSort = sortOrder;
                ViewBag.NomeParam = String.IsNullOrEmpty(sortOrder) ? "Nome_desc" : "";
                ViewBag.MatriculaParam = sortOrder == "Matricula" ? "Matricula_desc" : "Matricula";
                ViewBag.UnidadeParam = sortOrder == "Unidade" ? "Unidade_desc" : "Unidade";

                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = currenteFilter;
                }

                ViewBag.CurrenteFilter = searchString;

                var supridos = from s in db.AgentesSupridos
                               select s;

                if (!String.IsNullOrEmpty(searchString))
                {
                    supridos = supridos.Where(s => s.Nome.ToUpper().Contains(searchString.ToUpper())
                                                || s.UnidadeLotacao.ToString().Contains(searchString)
                                                || s.Matricula.ToString().Contains(searchString));
                }

                switch (sortOrder)
                {
                    case "Nome_desc":
                        supridos = supridos.OrderByDescending(s => s.Nome);
                        break;
                    case "Matricula":
                        supridos = supridos.OrderBy(s => s.Matricula);
                        break;
                    case "Matricula_desc":
                        supridos = supridos.OrderByDescending(s => s.Matricula);
                        break;
                    case "Unidade":
                        supridos = supridos.OrderBy(s => s.UnidadeLotacao);
                        break;
                    case "Unidade_desc":
                        supridos = supridos.OrderByDescending(s => s.UnidadeLotacao);
                        break;
                    default:
                        supridos = supridos.OrderBy(s => s.Nome);
                        break;
                }

                int pageSize = 5;
                int pageNumber = (page ?? 1);
                return View(supridos.ToPagedList(pageNumber, pageSize));
            }
            catch(Exception err)
            {
                ViewBag.DetalhesErro = err.Message.ToString();
                return View("Error");
            }
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteSuprido agenteSuprido = db.AgentesSupridos.Find(id);
            if (agenteSuprido == null)
            {
                return HttpNotFound();
            }
            return View(agenteSuprido);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgenteSuprido agenteSuprido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                
                    db.AgentesSupridos.Add(agenteSuprido);
                    db.SaveChanges();
                    TempData["Mensagem"] = "Cadastro efetuado com sucesso!";
                    return RedirectToAction("Index");
                }
                
            }
            catch (Exception err)
            {
                ViewBag.DetalhesErro = err.Message.ToString();
                return View("Error");
            }

            return View(agenteSuprido);
        }

        // GET: AgenteSuprido/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteSuprido agenteSuprido = db.AgentesSupridos.Find(id);
            if (agenteSuprido == null)
            {
                return HttpNotFound();
            }
            return View(agenteSuprido);
        }

        // POST: AgenteSuprido/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AgenteSuprido agenteSuprido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(agenteSuprido).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Mensagem"] = "Atualizações efetuadas com sucesso!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception err)
            {
                ViewBag.DetalhesErro = err.Message.ToString();
                return View("Error");
            }
            return View(agenteSuprido);
        }

        // GET: AgenteSuprido/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgenteSuprido agenteSuprido = db.AgentesSupridos.Find(id);
            if (agenteSuprido == null)
            {
                return HttpNotFound();
            }
            return View(agenteSuprido);
        }

        // POST: AgenteSuprido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                AgenteSuprido agenteSuprido = db.AgentesSupridos.Find(id);
                db.AgentesSupridos.Remove(agenteSuprido);
                db.SaveChanges();
                TempData["Mensagem"] = "Exclusão efetuada com sucesso!";
            }
            catch (Exception err)
            {
                ViewBag.DetalhesErro = err.Message.ToString();
                return View("Error");
            }
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
