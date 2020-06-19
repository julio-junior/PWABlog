using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminAutoresCriarViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }
        
        public AdminAutoresCriarViewModel()
        {
            TituloPagina = "Criar novo Autor";
        }
    }
}