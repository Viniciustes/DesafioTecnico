using Application.ViewModels;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IJurosService
    {
        Task<InformacoesGitViewModel> ShowMeTheCode();
        Task<TaxaJurosViewModel> BuscarTaxaJuros();
        Task<TaxaJurosViewModel> CalcularJuros(decimal valorInicial, int meses);
    }
}
