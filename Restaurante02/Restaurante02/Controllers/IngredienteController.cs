using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class IngredienteController : Controller
    {
        public Contexto Contexto { get; set; }

        public IngredienteController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: IngredienteController
        public ActionResult Index()
        {
            List<Ingrediente> ingredientes = Contexto.Ingredientes.ToList();
            return View(ingredientes);
        }

        // GET: IngredienteController/Details/5
        public ActionResult Details(int id)
        {
            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.Id == id).First();
            return View(ingrediente);
        }

        // GET: IngredienteController/Create
        public ActionResult Create()
        {
            Ingrediente ingrediente = new Ingrediente();
            return View(ingrediente);
        }

        // POST: IngredienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ingrediente ingrediente)
        {
            try
            {
                Contexto.Ingredientes.Add(ingrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IngredienteController/Edit/5
        public ActionResult Edit(int id)
        {
            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.Id == id).First();
            return View(ingrediente);
        }

        // POST: IngredienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ingrediente ingrediente)
        {
            try
            {
                Contexto.Ingredientes.Update(ingrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IngredienteController/Delete/5
        public ActionResult Delete(int id)
        {

            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.Id == id).First();
            return View(ingrediente);
        }

        // POST: IngredienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Ingrediente ingrediente)
        {
            try
            {
                Contexto.Ingredientes.Remove(ingrediente);
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
