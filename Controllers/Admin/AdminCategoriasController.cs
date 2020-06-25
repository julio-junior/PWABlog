using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PWABlog.Models.Blog.Categoria;
using PWABlog.RequestModels.AdminCategorias;
using PWABlog.ViewModels.Admin;

namespace PWABlog.Controllers.Admin
{
    [Authorize]
    public class AdminCategoriasController : Controller
    {
        private readonly CategoriaOrmService _categoriaOrmService;

        public AdminCategoriasController(
            CategoriaOrmService categoriaOrmService
        )
        {
            _categoriaOrmService = categoriaOrmService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            AdminCategoriasListarViewModel model = new AdminCategoriasListarViewModel();

            var listaCategorias = _categoriaOrmService.ObterCategorias();

            foreach (var categoriaEntity in listaCategorias)
            {
                var categoriaAdminCategorias = new CategoriaAdminCategorias();
                categoriaAdminCategorias.Id = categoriaEntity.Id;
                categoriaAdminCategorias.Nome = categoriaEntity.Nome;

                model.Categorias.Add(categoriaAdminCategorias);
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
            AdminCategoriasCriarViewModel model = new AdminCategoriasCriarViewModel();
            
            model.Erro = (string) TempData["erro-msg"];
            
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Criar(AdminCategoriasCriarRequestModel request)
        {
            
            var nome = request.Nome;

            try {
                _categoriaOrmService.CriarCategoria(nome);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Criar");
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            AdminCategoriasEditarViewModel model = new AdminCategoriasEditarViewModel();

            var categoriaEditar = _categoriaOrmService.ObterCategoriaPorId(id);

            if (categoriaEditar == null)
            {
                return RedirectToAction("Listar");
            }

            model.IdCategoria = categoriaEditar.Id;
            model.NomeCategoria = categoriaEditar.Nome;

            model.TituloPagina += model.NomeCategoria;
            
            model.Erro = (string) TempData["erro-msg"];

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Editar(AdminCategoriasEditarRequestModel request)
        {
            var id = request.Id;
            var nome = request.Nome;

            try {
                _categoriaOrmService.EditarCategoria(id, nome);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Editar", new {id = id});
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            AdminCategoriasRemoverViewModel model = new AdminCategoriasRemoverViewModel();

            var categoriaRemover = _categoriaOrmService.ObterCategoriaPorId(id);

            if (categoriaRemover == null)
            {
                return RedirectToAction("Listar");
            }

            model.IdCategoria = categoriaRemover.Id;
            model.NomeCategoria = categoriaRemover.Nome;

            model.TituloPagina += model.NomeCategoria;
            
            model.Erro = (string) TempData["erro-msg"];

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Remover(AdminCategoriasRemoverRequestModel request)
        {
            var id = request.Id;

            try {
                _categoriaOrmService.RemoverCategoria(id);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Remover", new {id = id});
            }

            return RedirectToAction("Listar");
        }
    }
}