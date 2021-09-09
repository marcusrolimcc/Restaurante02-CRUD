using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class PratoController : Controller
    {
        public Contexto Contexto { get; set; }

        public PratoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: PratoController
        public ActionResult Index()
        {
            List<Prato> pratos = Contexto.Pratos.ToList();
            return View(pratos);
        }

        // GET: PratoController/Details/5
        public ActionResult Details(int id)
        {
            Prato prato = Contexto.Pratos.Where(e => e.Id == id).First();
            return View(prato);
        }

        // GET: PratoController/Create
        public ActionResult Create()
        {
            Prato prato = new Prato();
            return View(prato);
        }

        // POST: PratoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prato prato)
        {
            try
            {
                Contexto.Pratos.Add(prato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PratoController/Edit/5
        public ActionResult Edit(int id)
        {
            Prato prato = Contexto.Pratos.Where(e => e.Id == id).First();
            return View(prato);
        }

        // POST: PratoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Prato prato)
        {
            try
            {
                Contexto.Pratos.Update(prato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PratoController/Delete/5
        public ActionResult Delete(int id)
        {

            Prato prato = Contexto.Pratos.Where(e => e.Id == id).First();
            return View(prato);
        }

        // POST: PratoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Prato prato)
        {
            try
            {
                Contexto.Pratos.Remove(prato);
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
