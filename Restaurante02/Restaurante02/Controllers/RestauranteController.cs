using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class RestauranteController : Controller
    {
        public Contexto Contexto { get; set; }

        public RestauranteController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: RestauranteController
        public ActionResult Index()
        {
            List<Restaurante> restaurantes = Contexto.Restaurantes.ToList();
            return View(restaurantes);
        }

        // GET: RestauranteController/Details/5
        public ActionResult Details(int id)
        {
            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.Id == id).First();
            return View(restaurante);
        }

        // GET: RestauranteController/Create
        public ActionResult Create()
        {
            Restaurante restaurante = new Restaurante();
            return View(restaurante);
        }

        // POST: RestauranteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurante restaurante)
        {
            try
            {
                Contexto.Restaurantes.Add(restaurante);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestauranteController/Edit/5
        public ActionResult Edit(int id)
        {
            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.Id == id).First();
            return View(restaurante);
        }

        // POST: RestauranteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Restaurante restaurante)
        {
            try
            {
                Contexto.Restaurantes.Update(restaurante);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestauranteController/Delete/5
        public ActionResult Delete(int id)
        {

            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.Id == id).First();
            return View(restaurante);
        }

        // POST: RestauranteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Restaurante restaurante)
        {
            try
            {
                Contexto.Restaurantes.Remove(restaurante);
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
