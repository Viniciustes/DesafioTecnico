using System;

namespace Domain.Models
{
    public class TaxaJuros
    {
        public decimal Taxa => 0.01m;

        public decimal CalcularJuros(decimal valorInicial, int meses) =>
            Math.Truncate(valorInicial * (decimal)Math.Pow((double)Taxa + 1, meses) * 100) / 100;
    }
}
