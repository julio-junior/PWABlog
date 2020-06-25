namespace PWABlog.ViewModels.Admin
{
    public class AdminCategoriasEditarViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }

        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }
        
        public AdminCategoriasEditarViewModel()
        {
            TituloPagina = "Editar Categoria: ";
        }
    }
}