using Backend;
using Backend.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioWebApp.Controllers
{
    public class MarcaController : Controller
    {
        private MarcaRepositorio repositorio;

        public MarcaController()
        {
            this.repositorio = new MarcaRepositorio();
        }
        // GET: Marca
        public ActionResult Index()
        {
            var marcas = repositorio.ObterTodos();
            return View(marcas);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marca/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection/*Marca collection*/)
        {
            try
            {
                var id = collection["Id"];
                var marca = new Marca
                {
                    Id = string.IsNullOrEmpty(id) ? 0 : int.Parse(id),
                    Nome = collection["Nome"]
                };

                //var marca  = collection; 

                if (marca.Id > 0)
                {
                    this.repositorio.Editar(marca);
                }
                else
                {
                    this.repositorio.Cadastrar(marca); 
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int id)
        {
            var marca = this.repositorio.ObterPorId(id);
            return View("Create", marca); 
        }

        // POST: Marca/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marca/Delete/5
        public ActionResult Delete(int id)
        {
            var marca = this.repositorio.ObterPorId(id);
            this.repositorio.Excluir(marca);
            return RedirectToAction("Index");
        }

        // POST: Marca/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
