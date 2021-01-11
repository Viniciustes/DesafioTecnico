namespace Application.ViewModels
{
    public class InformacoesGitViewModel
    {
        public InformacoesGitViewModel(string nome, string url)
        {
            Nome = nome;
            Url = url;
        }

        public string Nome { get; set; }

        public string Url { get; set; }
    }
}
