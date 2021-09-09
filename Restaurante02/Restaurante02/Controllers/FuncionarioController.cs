using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Controllers
{
    public class FuncionarioController : Controller
    {
        public Contexto Contexto { get; set; }

        public FuncionarioController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        // GET: FuncionarioController
        public ActionResult Index()
        {
            List<Funcionario> funcionarios = Contexto.Funcionarios.ToList();
            return View(funcionarios);
        }

        // GET: FuncionarioController/Details/5
        public ActionResult Details(int id)
        {
            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.Id == id).First();
            return View(funcionario);
        }

        // GET: FuncionarioController/Create
        public ActionResult Create()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }

        // POST: FuncionarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario funcionario)
        {
            try
            {
                Contexto.Funcionarios.Add(funcionario);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncionarioController/Edit/5
        public ActionResult Edit(int id)
        {
            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.Id == id).First();
            return View(funcionario);
        }

        // POST: FuncionarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Funcionario funcionario)
        {
            try
            {
                Contexto.Funcionarios.Update(funcionario);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncionarioController/Delete/5
        public ActionResult Delete(int id)
        {

            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.Id == id).First();
            return View(funcionario);
        }

        // POST: FuncionarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Funcionario funcionario)
        {
            try
            {
                Contexto.Funcionarios.Remove(funcionario);
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
