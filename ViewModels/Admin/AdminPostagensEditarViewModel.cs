using System;
using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminPostagensEditarViewModel : ViewModelAreaAdministrativa
    {
        public int IdPostagem { get; set; }

        public string TituloPostagem { get; set; }

        public string DescricaoPostagem { get; set; }

        public int IdAutorPostagem { get; set; }

        public int IdCategoriaPostagem { get; set; }

        public DateTime DataPostagem { get; set; }

        public string Erro { get; set; }

        public ICollection<AutorAdminPostagens> Autores { get; set; }
        
        public ICollection<CategoriaAdminPostagens> Categorias { get; set; }

        public ICollection<EtiquetaAdminPostagens> Etiquetas { get; set; }

        public AdminPostagensEditarViewModel()
        {
            TituloPagina = "Editar Postagem ";
            Autores = new List<AutorAdminPostagens>();
            Categorias = new List<CategoriaAdminPostagens>();
            Etiquetas = new List<EtiquetaAdminPostagens>();
        }
    }
}