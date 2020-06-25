using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PWABlog.Models.Blog.Autor;
using PWABlog.Models.Blog.Categoria;
using PWABlog.Models.Blog.Etiqueta;
using PWABlog.Models.Blog.Postagem;
using PWABlog.RequestModels.AdminPostagens;
using PWABlog.ViewModels;
using PWABlog.ViewModels.Admin;

namespace PWABlog.Controllers.Admin
{
    [Authorize]
    public class AdminPostagensController : Controller
    {
        private readonly PostagemOrmService _postagemOrmService;
        private readonly CategoriaOrmService _categoriaOrmService;
        private readonly AutorOrmService _autorOrmService;
        private readonly EtiquetaOrmService _etiquetaOrmService;

        public AdminPostagensController(
            PostagemOrmService postagemOrmService,
            CategoriaOrmService categoriaOrmService,
            AutorOrmService autorOrmService,
            EtiquetaOrmService etiquetaOrmService
        )
        {
            _postagemOrmService = postagemOrmService;
            _categoriaOrmService = categoriaOrmService;
            _autorOrmService = autorOrmService;
            _etiquetaOrmService = etiquetaOrmService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            AdminPostagensListarViewModel model = new AdminPostagensListarViewModel();

            var listaPostagens = _postagemOrmService.ObterPostagens();

            foreach (var postagemEntity in listaPostagens)
            {
                var postagemAdminPostagens = new PostagemAdminPostagens();
                postagemAdminPostagens.IdPostagem = postagemEntity.Id;
                postagemAdminPostagens.TituloPostagem = postagemEntity.Titulo;
                postagemAdminPostagens.NomeAutorPost = postagemEntity.Autor.Nome;
                postagemAdminPostagens.NomeCategoriaPost = postagemEntity.Categoria.Nome;
                
                model.Postagens.Add(postagemAdminPostagens);
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
            AdminPostagensCriarViewModel model = new AdminPostagensCriarViewModel();
            model.Erro = (string) TempData["erro-msg"];

            var listaCategorias = _categoriaOrmService.ObterCategorias();
            foreach (var categoriaEntity in listaCategorias)
            {
                var categoriaAdmPostagens = new CategoriaAdminPostagens();
                categoriaAdmPostagens.IdCategoria = categoriaEntity.Id;
                categoriaAdmPostagens.NomeCategoria = categoriaEntity.Nome;
                
                model.Categorias.Add(categoriaAdmPostagens);
            }

            var listaAutores = _autorOrmService.ObterAutores();
            foreach (var autorEntity in listaAutores)
            {
                var autorAdminPostagens = new AutorAdminPostagens();
                autorAdminPostagens.IdAutor = autorEntity.Id;
                autorAdminPostagens.NomeAutor = autorEntity.Nome;
                
                model.Autores.Add(autorAdminPostagens);
            }

            var listaEtiquetas = _etiquetaOrmService.ObterEtiquetas();
            foreach (var etiquetaEntity in listaEtiquetas)
            {
                var etiquetaAdminPostagens = new EtiquetaAdminPostagens();
                etiquetaAdminPostagens.IdEtiqueta = etiquetaEntity.Id;
                etiquetaAdminPostagens.NomeEtiqueta = etiquetaEntity.Nome;
                
                model.Etiquetas.Add(etiquetaAdminPostagens);
            }

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Criar(AdminPostagensCriarRequestModel request)
        {
            var titulo = request.Titulo;
            var descricao = request.Descricao;
            var idAutor = request.IdAutor;
            var idCategoria = request.IdCategoria;
            var texto = request.Texto;
            var dataExibicao = DateTime.Parse(request.DataExibicao);
            
            try {
                _postagemOrmService.CriarPostagem(titulo, descricao, idAutor, idCategoria, texto, dataExibicao);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Criar");
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            AdminPostagensEditarViewModel model = new AdminPostagensEditarViewModel();

            var editarPostagem = _postagemOrmService.ObterPostagemPorId(id);

            if (editarPostagem == null)
            {
                return RedirectToAction("Listar");
            }

            var listaCategoria = _categoriaOrmService.ObterCategorias();
            foreach (var categoriaEntity in listaCategoria)
            {
                var categoriaAdminPostagens = new CategoriaAdminPostagens();
                categoriaAdminPostagens.IdCategoria = categoriaEntity.Id;
                categoriaAdminPostagens.NomeCategoria = categoriaEntity.Nome;
                
                model.Categorias.Add(categoriaAdminPostagens);
            }

            var listaAutor = _autorOrmService.ObterAutores();
            foreach (var autorEntity in listaAutor)
            {
                var autorAdminPostagens = new AutorAdminPostagens();
                autorAdminPostagens.IdAutor = autorEntity.Id;
                autorAdminPostagens.NomeAutor = autorEntity.Nome;
                
                model.Autores.Add(autorAdminPostagens);
            }

            var listaEtiqueta = _etiquetaOrmService.ObterEtiquetas();
            foreach(var etiquetaEntity in listaEtiqueta)
            {
                var etiquetaAdminPostagens = new EtiquetaAdminPostagens();
                etiquetaAdminPostagens.IdEtiqueta = etiquetaEntity.Id;
                etiquetaAdminPostagens.NomeEtiqueta = etiquetaEntity.Nome;
                model.Etiquetas.Add(etiquetaAdminPostagens);
            }

            model.IdPostagem = editarPostagem.Id;
            model.TituloPostagem = editarPostagem.Titulo;
            model.DescricaoPostagem = editarPostagem.Descricao;
            model.IdAutorPostagem = editarPostagem.Autor.Id;
            model.IdCategoriaPostagem = editarPostagem.Categoria.Id;
            model.DataPostagem = editarPostagem.DataExibicao;
            
            model.Erro = (string) TempData["erro-msg"];

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Editar(AdminPostagensEditarRequestModel request)
        {
            var id = request.Id;
            var titulo = request.Texto;
            var descricao = request.Descricao;
            var idCategoria = Convert.ToInt32(request.IdCategoria);
            var texto = request.Texto;
            var dataExibicao = DateTime.Parse(request.DataExibicao);

            try {
                _postagemOrmService.EditarPostagem(id, titulo, descricao, idCategoria, texto, dataExibicao);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Editar", new {id = id});
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            AdminPostagensRemoverViewModel model = new AdminPostagensRemoverViewModel();

            var postagemRemover = _postagemOrmService.ObterPostagemPorId(id);

            if (postagemRemover == null)
            {
                return RedirectToAction("Listar");
            }

            model.IdPostagem = postagemRemover.Id;
            model.TituloPostagem = postagemRemover.Titulo;
            model.TituloPagina += model.TituloPostagem;
            
            model.Erro = (string) TempData["erro-msg"];

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Remover(AdminPostagensRemoverRequestModel request)
        {
            var id = request.Id;

            try {
                _postagemOrmService.RemoverPostagem(id);
            } catch (Exception exception) {
                TempData["erro-msg"] = exception.Message;
                return RedirectToAction("Remover", new {id = id});
            }

            return RedirectToAction("Listar");
        }
    }
}