using AutoMapper;
using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModeloDDD_AV2.MVC.Controllers
{
    public class ProcessosController : Controller
    {
        private readonly IProcessoAppService _processoApp;
        private readonly IFornecedorAppService _fornecedorApp;


        public ProcessosController(IProcessoAppService processoApp, IFornecedorAppService fornecedorApp)
        {
            _processoApp = processoApp;
            _fornecedorApp = fornecedorApp;
        }

        // GET: Processo
        public ActionResult Index()
        {
            var processoViewModel = Mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(_processoApp.GetAll());
            return View(processoViewModel);
        }

        // GET: Processo/Details/5
        public ActionResult Details(int id)
        {
            var processo = _processoApp.GetById(id);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // GET: Processo/Create
        public ActionResult Create(string PesquisaCnpj = "")
        {
            
            if (!string.IsNullOrEmpty(PesquisaCnpj))
            {
                Fornecedor fornecedor = _fornecedorApp.BuscarPorCnpj(PesquisaCnpj);                

                if (fornecedor != null)
                {
                    ProcessoViewModel procViewModel = new ProcessoViewModel();
                    procViewModel.Cnpj = PesquisaCnpj;
                    procViewModel.FornecedorId = fornecedor.FornecedorId;
                    ViewBag.FornecedorId = fornecedor.FornecedorId;
                    procViewModel.RazaoSocial = fornecedor.RazaoSocial;
                    procViewModel.InscricaoMunicipal = fornecedor.InscricaoMunicipal;
                    return View(procViewModel);
                }
                else
                {
                    ProcessoViewModel procViewModel = new ProcessoViewModel();
                    procViewModel.Cnpj = "CNPJ NÃO ENCONTRADO";
                    return View(procViewModel);
                }
            }
            return View();
        }

        // POST: Processo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProcessoViewModel processo)
        {
            var processoDomain = Mapper.Map<ProcessoViewModel, Processo>(processo);
            _processoApp.Add(processoDomain);

            return RedirectToAction("Index");
        }

        // GET: Processo/Edit/5
        public ActionResult Edit(int id)
        {
            var processo = _processoApp.GetById(id);
            processo.Fornecedor = _fornecedorApp.GetById(processo.FornecedorId);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // POST: Processo/Edit/5
        [HttpPost]
        public ActionResult Edit(ProcessoViewModel processo)
        {
            if (ModelState.IsValid)
            {
                var processomain = Mapper.Map<ProcessoViewModel, Processo>(processo);
                _processoApp.Update(processomain);

                return RedirectToAction("Index");

            }
            return View(processo);
        }

        // GET: Processo/Delete/5
        public ActionResult Delete(int id)
        {
            var processo = _processoApp.GetById(id);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // POST: Processo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var processo = _processoApp.GetById(id);
            _processoApp.Remove(processo);
            return RedirectToAction("Index");

        }
    }
}