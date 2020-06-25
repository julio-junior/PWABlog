using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminPostagensListarViewModel : ViewModelAreaAdministrativa
    {
        public ICollection<PostagemAdminPostagens> Postagens { get; set; } 
        
        public AdminPostagensListarViewModel()
        {
            TituloPagina = "Postagens - Administrador";
            Postagens = new List<PostagemAdminPostagens>();
        }
    }

    public class PostagemAdminPostagens
    {
        public int IdPostagem { get; set; }

        public string TituloPostagem { get; set; }

        public string NomeAutorPost { get; set; }

        public string NomeCategoriaPost { get; set; }
    }
}