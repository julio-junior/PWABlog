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
            
            model.Erro = (string) TempData["erro-msg"];

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
            AdminAutoresEditarViewModel model = new AdminAutoresEditarViewModel();

            var autorEditar = _autoresOrmService.ObterAutorPorId(id);

            if (autorEditar == null)
            {
                return RedirectToAction("Listar");
            }
            
            model.Erro = (string) TempData["erro-msg"];

            model.idAutor = autorEditar.Id;
            model.nomeAutor = autorEditar.Nome;
            model.TituloPagina += model.nomeAutor;
            
            return View(model);
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
            AdminAutoresRemoverViewModel model = new AdminAutoresRemoverViewModel();

            var autorRemover = _autoresOrmService.ObterAutorPorId(id);

            if (autorRemover == null)
            {
                return RedirectToAction("Listar");
            }

            model.IdAutor = autorRemover.Id;
            model.NomeAutor = autorRemover.Nome;
            model.TituloPagina += model.NomeAutor;
            
            model.Erro = (string) TempData["erro-msg"];

            return View(model);
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