using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class ClienteController : Controller
    {
        public Contexto Contexto { get; set; }

        public ClienteController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            List<Cliente> clientes = Contexto.Clientes.ToList();
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            Cliente cliente = Contexto.Clientes.Where(e => e.Id == id).First();
            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                Contexto.Clientes.Add(cliente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            Cliente cliente = Contexto.Clientes.Where(e => e.Id == id).First();
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                Contexto.Clientes.Update(cliente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {

            Cliente cliente = Contexto.Clientes.Where(e => e.Id == id).First();
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                Contexto.Clientes.Remove(cliente);
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
