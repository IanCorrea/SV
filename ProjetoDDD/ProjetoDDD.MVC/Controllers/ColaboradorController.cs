using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;
using System.Collections.Generic;
using ProjetoDDD.Application.Interface;
using static ProjetoDDD.MVC.RouteConfig;

namespace ProjetoDDD.MVC.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorAppService _colaboradorApp;

        public ColaboradorController(IColaboradorAppService colaboradorApp)
        {
            _colaboradorApp = colaboradorApp;
        }

        // GET: Colaborador
        public ActionResult Index()
        {
            ViewBag.PanelType = "panel-provider";
            ViewBag.PanelTitle = "Colaboradores";
            var colaboradorviewmodel = Mapper.Map<IEnumerable<Colaborador>, IEnumerable<ColaboradorViewModel>>(_colaboradorApp.GetAll());
            return View(colaboradorviewmodel);
        }

        // GET: Colaborador/Details/5
        [NoDirectAccess]
        public ActionResult Details(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaborador, ColaboradorViewModel>(colaborador);
            ViewBag.Sexo = colaborador.Sexo;

            return View(colaboradorViewModel);
        }

        // GET: Colaborador/Create
        [NoDirectAccess]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaborador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ColaboradorViewModel colaborador)
        {
            if (ModelState.IsValid)
            {
                var colaboradorDomain = Mapper.Map<ColaboradorViewModel, Colaborador>(colaborador);
                _colaboradorApp.Add(colaboradorDomain);

                return RedirectToAction("Index");
            }

            return View(colaborador);
        }

        // GET: Colaborador/Edit/5
        [NoDirectAccess]
        public ActionResult Edit(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaborador, ColaboradorViewModel>(colaborador);

            return View(colaboradorViewModel);
        }

        // POST: Colaborador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ColaboradorViewModel colaborador)
        {
            if (ModelState.IsValid)
            {
                var colaboradorDomain = Mapper.Map<ColaboradorViewModel, Colaborador>(colaborador);
                _colaboradorApp.Update(colaboradorDomain);

                return RedirectToAction("Index");
            }

            return View(colaborador);
        }

        // GET: Colaborador/Delete/5
        [NoDirectAccess]
        public ActionResult Delete(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaborador, ColaboradorViewModel>(colaborador);

            return View(colaboradorViewModel);
        }

        // POST: Colaborador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            _colaboradorApp.Remove(colaborador);

            return RedirectToAction("Index");
        }
    }
}
