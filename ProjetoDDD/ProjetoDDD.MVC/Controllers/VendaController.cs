using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;
using System.Collections.Generic;
using ProjetoDDD.Application.Interface;
using System.Linq;
using static ProjetoDDD.MVC.RouteConfig;

namespace ProjetoDDD.MVC.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaAppService _vendaApp;
        private readonly IClienteAppService _clienteApp;
        private readonly IColaboradorAppService _colaboradorApp;

        public VendaController(IVendaAppService vendaApp, IClienteAppService clienteApp, IColaboradorAppService colaboradorApp)
        {
            _vendaApp = vendaApp;
            _clienteApp = clienteApp;
            _colaboradorApp = colaboradorApp;
        }

        // GET: Venda
        public ActionResult Index()
        {
            ViewBag.PanelType = "panel-sales";
            ViewBag.PanelTitle = "Vendas";
            var vendaviewmodel = Mapper.Map<IEnumerable<Venda>, IEnumerable<VendaViewModel>>(_vendaApp.GetAll());
            return View(vendaviewmodel);
        }

        // GET: Venda/Details/?
        [NoDirectAccess]
        public ActionResult Details(int id)
        {
            var venda = _vendaApp.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);

            return View(vendaViewModel);
        }

        // GET: Venda/Create
        [NoDirectAccess]
        public ActionResult Create()
        {
            ViewBag.ClienteList = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            ViewBag.ColaboradorList = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome");
            return View();
        }

        // POST: Venda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VendaViewModel venda)
        {
            if (ModelState.IsValid)
            {
                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(venda);
                _vendaApp.Add(vendaDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteList = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", venda.ClienteId);
            ViewBag.ColaboradorList = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", venda.ColaboradorId);
            return View(venda);
        }

        // GET: Venda/Edit/?
        [NoDirectAccess]
        public ActionResult Edit(int id)
        {            
            var venda = _vendaApp.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);

            ViewBag.ClienteList = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", vendaViewModel.ClienteId);
            ViewBag.ColaboradorList = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", vendaViewModel.ColaboradorId);
            
            return View(vendaViewModel);
        }

        // POST: Venda/Edit/?
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VendaViewModel venda)
        {
            if (ModelState.IsValid)
            {
                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(venda);
                _vendaApp.Update(vendaDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteList = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", venda.ClienteId);
            ViewBag.ColaboradorList = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", venda.ColaboradorId);
            return View(venda);
        }

        // GET: Venda/Delete/?
        [NoDirectAccess]
        public ActionResult Delete(int id)
        {
            var venda = _vendaApp.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);

            return View(vendaViewModel);
        }

        // POST: Venda/Delete/?
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var venda = _vendaApp.GetById(id);
            _vendaApp.Remove(venda);

            return RedirectToAction("Index");
        }

        public ActionResult Report()
        {
            ViewBag.PanelType = "panel-report";
            ViewBag.PanelTitle = "Relatório de Vendas";
            return View();
        }
    }
}
