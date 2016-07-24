using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CadnunsDev.AngularECommerce.Application;
using CadnunsDev.AngularECommerce.Application.Interfaces;
using CadnunsDev.AngularECommerce.Application.ViewModels;
using CadnunsDev.AngularECommerce.UI.Admin.Models;

namespace CadnunsDev.AngularECommerce.UI.Admin.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutoAppService _produtoAppService;
        //private lalllkasjContext db = new lalllkasjContext();
        public ProdutosController()
        {
            _produtoAppService = new ProdutoAppService();
        }

        // GET: ProdutoViewModels
        public ActionResult Index()
        {
            return View(_produtoAppService.ObterTodos());
        }

        // GET: ProdutoViewModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        // GET: ProdutoViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,Nome,Descricao,Preco,CodigoBarras")] ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoAppService.Adicionar(produtoViewModel);
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }

        // GET: ProdutoViewModels/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        // POST: ProdutoViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutoId,Nome,Descricao,Preco,CodigoBarras")] ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoAppService.Atualizar(produtoViewModel);
                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

        // GET: ProdutoViewModels/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        // POST: ProdutoViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _produtoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _produtoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
