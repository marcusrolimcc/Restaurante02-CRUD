using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class Item_VendaController : Controller
    {
        public Contexto Contexto { get; set; }

        public Item_VendaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: Item_VendaController
        public ActionResult Index()
        {
            List<Item_Venda> item_Vendas = Contexto.Item_Vendas.ToList();
            return View(item_Vendas);
        }

        // GET: Item_VendaController/Details/5
        public ActionResult Details(int id)
        {
            Item_Venda item_Venda = Contexto.Item_Vendas.Where(e => e.Id == id).First();
            return View(item_Venda);
        }

        // GET: Item_VendaController/Create
        public ActionResult Create()
        {
            Item_Venda item_Venda = new Item_Venda();
            return View(item_Venda);
        }

        // POST: Item_VendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item_Venda item_Venda)
        {
            try
            {
                Contexto.Item_Vendas.Add(item_Venda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_VendaController/Edit/5
        public ActionResult Edit(int id)
        {
            Item_Venda item_Venda = Contexto.Item_Vendas.Where(e => e.Id == id).First();
            return View(item_Venda);
        }

        // POST: Item_VendaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Item_Venda item_Venda)
        {
            try
            {
                Contexto.Item_Vendas.Update(item_Venda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_VendaController/Delete/5
        public ActionResult Delete(int id)
        {

            Item_Venda item_Venda = Contexto.Item_Vendas.Where(e => e.Id == id).First();
            return View(item_Venda);
        }

        // POST: Item_VendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Item_Venda item_Venda)
        {
            try
            {
                Contexto.Item_Vendas.Remove(item_Venda);
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
