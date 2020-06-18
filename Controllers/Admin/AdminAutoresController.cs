using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PWABlog.Models.Blog.Autor;
using PWABlog.RequestModels.AdminAutores;
using PWABlog.ViewModels.Admin;

namespace PWABlog.Controllers.Admin
{
    [Authorize]
    public class AdminAutoresController : Controller
    {
        private readonly AutorOrmService _autoresOrmService;

        public AdminAutoresController(
            AutorOrmService autoresOrmService
        )
        {
            _autoresOrmService = autoresOrmService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            AdminAutoresListarViewModel model = new AdminAutoresListarViewModel();

            var listaAutores = _autoresOrmService.ObterAutores();

            foreach (var autorEntity in listaAutores)
            {
                var autorAdminAutores = new AutorAdminAutores();
                autorAdminAutores.Id = autorEntity.Id;
                autorAdminAutores.Nome = autorEntity.Nome;

                model.Autores.Add(autorAdminAutores);
            }
            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Detalhar(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Criar()
        {
            AdminAutoresCriarViewModel model = new AdminAutoresCriarViewModel();
            
            ViewBag.erro = TempData["erro-msg"];

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Criar(AdminAutoresCriarRequestModel request)
        {
            var nome = request.Nome;

            try {
                _autoresOrmService.CriarAutor(nome);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Criar");
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            ViewBag.id = id;
            ViewBag.erro = TempData["erro-msg"];

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Editar(AdminAutoresEditarRequestModel request)
        {
            var id = request.Id;
            var nome = request.Nome;

            try {
                _autoresOrmService.EditarAutor(id, nome);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Editar", new {id = id});
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            ViewBag.id = id;
            ViewBag.erro = TempData["erro-msg"];

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Remover(AdminAutoresRemoverRequestModel request)
        {
            var id = request.Id;

            try {
                _autoresOrmService.RemoverAutor(id);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Remover", new {id = id});
            }

            return RedirectToAction("Listar");
        }
    }
}