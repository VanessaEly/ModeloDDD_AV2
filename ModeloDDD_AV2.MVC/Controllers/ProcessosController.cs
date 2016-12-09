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

        public ProcessosController()
        {
        }

        public ProcessosController(IProcessoAppService processoApp)
        {
            _processoApp = processoApp;
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
        public ActionResult Create()
        {
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