namespace Application.ViewModels
{
    public class TaxaJurosViewModel
    {
        public TaxaJurosViewModel(decimal taxa)
        {
            Taxa = string.Format("{0:0.00}", taxa);
        }

        public string Taxa { get; set; }
    }
}
