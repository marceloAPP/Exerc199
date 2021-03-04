using System;
using System.Globalization;

namespace _199_Exerc.Entities
{
    class Prestacao
    {
        public DateTime DataVencimento { get; set; }
        public double Quantidade { get; set; }

        public Prestacao(DateTime dataVencimento, double quantidade)
        {
            DataVencimento = dataVencimento;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return "Prestações: " + DataVencimento.ToString("dd/mm/yyyy")
                + " - "
                + Quantidade.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
