using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminPostagensCriarViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }
        
        public ICollection<CategoriaAdminPostagens> Categorias { get; set; }

        public ICollection<AutorAdminPostagens> Autores { get; set; }

        public ICollection<EtiquetaAdminPostagens> Etiquetas { get; set; }

        public AdminPostagensCriarViewModel()
        {
            TituloPagina = "Criar nova Postagem";
            Categorias = new List<CategoriaAdminPostagens>();
            Autores = new List<AutorAdminPostagens>();
            Etiquetas = new List<EtiquetaAdminPostagens>();
        }
    }

    public class CategoriaAdminPostagens
    {
        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }
    }

    public class AutorAdminPostagens
    {
        public int IdAutor { get; set; }

        public string NomeAutor { get; set; }
    }

    public class EtiquetaAdminPostagens
    {
        public int IdEtiqueta { get; set; }
        public string NomeEtiqueta { get; set; }
    }
}