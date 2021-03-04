using System;

namespace _199_Exerc.Services
{
    class PaypalService : IServicoPagamentoOnline
    {
        private const double PocentagemTaxa = 0.2;
        private const double TaxaMensal = 0.1;

        public double Interesse(double quant, int meses)
        {
            return quant * PocentagemTaxa * meses;
        }

        public double TaxaDePagamento(double quant)
        {
            return quant * PocentagemTaxa;
        }
    }
}
