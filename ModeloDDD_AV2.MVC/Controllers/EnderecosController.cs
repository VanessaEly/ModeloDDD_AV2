using AutoMapper;
using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModeloDDD_AV2.MVC.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoAppService _enderecoApp;

        public EnderecosController()
        {
        }

        public EnderecosController(IEnderecoAppService enderecoApp)
        {
            _enderecoApp = enderecoApp;
        }

        // GET: Endereco
        public ActionResult Index()
        {
            var enderecoViewModel = Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoApp.GetAll());
            return View(enderecoViewModel);
        }

        // GET: Endereco/Details/5
        public ActionResult Details(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // GET: Endereco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Endereco/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnderecoViewModel endereco)
        {
            var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
            _enderecoApp.Add(enderecoDomain);

            return RedirectToAction("Index");
        }

        // GET: Endereco/Edit/5
        public ActionResult Edit(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // POST: Endereco/Edit/5
        [HttpPost]
        public ActionResult Edit(EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Update(enderecoDomain);

                return RedirectToAction("Index");

            }
            return View(endereco);
        }

        // GET: Endereco/Delete/5
        public ActionResult Delete(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // POST: Endereco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            _enderecoApp.Remove(endereco);
            return RedirectToAction("Index");

        }
    }
}