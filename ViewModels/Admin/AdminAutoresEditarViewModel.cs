namespace PWABlog.ViewModels.Admin
{
    public class AdminAutoresEditarViewModel : ViewModelAreaAdministrativa
    {
        public int idAutor { get; set; }

        public string nomeAutor { get; set; }
        
        public string Erro { get; set; }

        public AdminAutoresEditarViewModel()
        {
            TituloPagina = "Editar Autor: ";
        }
    }
}