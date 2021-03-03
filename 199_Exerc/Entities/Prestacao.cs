using System;

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
    }
}
