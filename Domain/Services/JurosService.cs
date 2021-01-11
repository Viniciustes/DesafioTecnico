using Application.Interfaces;
using Application.ViewModels;
using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class JurosService : IJurosService
    {
        public Task<TaxaJurosViewModel> BuscarTaxaJuros()
        {
            var taxaJuros = new TaxaJuros();

            return Task.FromResult(new TaxaJurosViewModel(taxaJuros.Taxa));
        }

        public Task<TaxaJurosViewModel> CalcularJuros(decimal valorInicial, int meses)
        {
            var taxaJuros = new TaxaJuros();

            var resultado = taxaJuros.CalcularJuros(valorInicial, meses);

            return Task.FromResult(new TaxaJurosViewModel(resultado));
        }

        public Task<InformacoesGitViewModel> ShowMeTheCode()
        {
            var informacoesGit = new InformacoesGit();

            return Task.FromResult(new InformacoesGitViewModel(informacoesGit.Nome, informacoesGit.Url));
        }
    }
}
