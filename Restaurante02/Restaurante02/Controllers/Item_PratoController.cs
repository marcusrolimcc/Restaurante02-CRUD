using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class Item_PratoController : Controller
    {
        public Contexto Contexto { get; set; }

        public Item_PratoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: Item_PratoController
        public ActionResult Index()
        {
            List<Item_Prato> item_Pratos = Contexto.Item_Pratos.ToList();
            return View(item_Pratos);
        }

        // GET: Item_PratoController/Details/5
        public ActionResult Details(int id)
        {
            Item_Prato item_Prato = Contexto.Item_Pratos.Where(e => e.Id == id).First();
            return View(item_Prato);
        }

        // GET: Item_PratoController/Create
        public ActionResult Create()
        {
            Item_Prato item_Prato = new Item_Prato();
            return View(item_Prato);
        }

        // POST: Item_PratoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item_Prato item_Prato)
        {
            try
            {
                Contexto.Item_Pratos.Add(item_Prato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_PratoController/Edit/5
        public ActionResult Edit(int id)
        {
            Item_Prato item_Prato = Contexto.Item_Pratos.Where(e => e.Id == id).First();
            return View(item_Prato);
        }

        // POST: Item_PratoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Item_Prato item_Prato)
        {
            try
            {
                Contexto.Item_Pratos.Update(item_Prato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_PratoController/Delete/5
        public ActionResult Delete(int id)
        {

            Item_Prato item_Prato = Contexto.Item_Pratos.Where(e => e.Id == id).First();
            return View(item_Prato);
        }

        // POST: Item_PratoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Item_Prato item_Prato)
        {
            try
            {
                Contexto.Item_Pratos.Remove(item_Prato);
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
