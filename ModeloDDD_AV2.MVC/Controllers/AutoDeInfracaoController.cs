using AutoMapper;
using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModeloDDD_AV2.MVC.Controllers
{
    public class AutoDeInfracaoController : Controller
    {
        private readonly IAutoDeInfracaoAppService _autoDeInfracaoApp;

        public AutoDeInfracaoController()
        {
        }

        public AutoDeInfracaoController(IAutoDeInfracaoAppService autoDeInfracaoApp)
        {
            _autoDeInfracaoApp = autoDeInfracaoApp;
        }

        // GET: AutoDeInfracao
        public ActionResult Index()
        {
            var autoDeInfracaoViewModel = Mapper.Map<IEnumerable<AutoDeInfracao>, IEnumerable<AutoDeInfracaoViewModel>>(_autoDeInfracaoApp.GetAll());
            return View(autoDeInfracaoViewModel);
        }

        // GET: AutoDeInfracao/Details/5
        public ActionResult Details(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // GET: AutoDeInfracao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoDeInfracao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AutoDeInfracaoViewModel autoDeInfracao)
        {
            var autoDeInfracaoDomain = Mapper.Map<AutoDeInfracaoViewModel, AutoDeInfracao>(autoDeInfracao);
            _autoDeInfracaoApp.Add(autoDeInfracaoDomain);

            return RedirectToAction("Index");
        }

        // GET: AutoDeInfracao/Edit/5
        public ActionResult Edit(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // POST: AutoDeInfracao/Edit/5
        [HttpPost]
        public ActionResult Edit(AutoDeInfracaoViewModel autoDeInfracao)
        {
            if (ModelState.IsValid)
            {
                var autoDeInfracaoDomain = Mapper.Map<AutoDeInfracaoViewModel, AutoDeInfracao>(autoDeInfracao);
                _autoDeInfracaoApp.Update(autoDeInfracaoDomain);

                return RedirectToAction("Index");

            }
            return View(autoDeInfracao);
        }

        // GET: AutoDeInfracao/Delete/5
        public ActionResult Delete(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // POST: AutoDeInfracao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            _autoDeInfracaoApp.Remove(autoDeInfracao);
            return RedirectToAction("Index");

        }
    }
}