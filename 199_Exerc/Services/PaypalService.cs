using System;

namespace _199_Exerc.Services
{
    class PaypalService
    {
        public double TaxaDePagamento(double quant)
        {
            return quant;
        }

        public double Interesse(double quant, int meses)
        {
            return  quant * meses;
        }
    }
}
