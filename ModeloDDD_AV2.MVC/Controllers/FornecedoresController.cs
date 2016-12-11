using AutoMapper;
using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModeloDDD_AV2.MVC.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorAppService _fornecedorApp;

        public FornecedoresController()
        {
        }

        public FornecedoresController(IFornecedorAppService fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }

        // GET: Fornecedor
        public ActionResult Index()
        {
            var fornecedorViewModel = Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorApp.GetAll());
            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedor, EnderecoViewModel endereco)
        {
            var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
            var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);

            fornecedorDomain.Enderecos.Add(enderecoDomain);
            _fornecedorApp.Add(fornecedorDomain);

            return RedirectToAction("Index");
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        public ActionResult Edit(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
                _fornecedorApp.Update(fornecedorDomain);

                return RedirectToAction("Index");

            }
            return View(fornecedor);
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);

        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            _fornecedorApp.Remove(fornecedor);
            return RedirectToAction("Index");

        }
    }
}