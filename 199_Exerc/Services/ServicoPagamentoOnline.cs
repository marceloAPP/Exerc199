namespace _199_Exerc.Services
{
    interface IServicoPagamentoOnline
    {
        double TaxaDePagamento(double quant);
        double Interesse(double quant, int meses);
    }
}
