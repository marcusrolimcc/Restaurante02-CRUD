using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class VendaController : Controller
    {
        public Contexto Contexto { get; set; }

        public VendaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: VendaController
        public ActionResult Index()
        {
            List<Venda> vendas = Contexto.Vendas.ToList();
            return View(vendas);
        }

        // GET: VendaController/Details/5
        public ActionResult Details(int id)
        {
            Venda venda = Contexto.Vendas.Where(e => e.Id == id).First();
            return View(venda);
        }

        // GET: VendaController/Create
        public ActionResult Create()
        {
            Venda venda = new Venda();
            return View(venda);
        }

        // POST: VendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Venda venda)
        {
            try
            {
                Contexto.Vendas.Add(venda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendaController/Edit/5
        public ActionResult Edit(int id)
        {
            Venda venda = Contexto.Vendas.Where(e => e.Id == id).First();
            return View(venda);
        }

        // POST: VendaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Venda venda)
        {
            try
            {
                Contexto.Vendas.Update(venda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendaController/Delete/5
        public ActionResult Delete(int id)
        {

            Venda venda = Contexto.Vendas.Where(e => e.Id == id).First();
            return View(venda);
        }

        // POST: VendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Venda venda)
        {
            try
            {
                Contexto.Vendas.Remove(venda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
