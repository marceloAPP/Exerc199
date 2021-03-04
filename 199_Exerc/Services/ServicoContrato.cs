using System;
using _199_Exerc.Entities;

namespace _199_Exerc.Services
{
    class ServicoContrato
    {
        IServicoPagamentoOnline _IServicoPagamentoOnline;

        public ServicoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _IServicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int qtdMeses)
        {
            double parcelaSimples = contrato.ValorTotal / qtdMeses;

            for (int i = 0; i < qtdMeses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double parcelaAtualizada = parcelaSimples + _IServicoPagamentoOnline.Interesse(parcelaSimples, i);
                double parcelaCompleta = parcelaAtualizada + _IServicoPagamentoOnline.TaxaDePagamento(parcelaAtualizada);

                contrato.AdicionaPrestacoes(new Prestacao(data, parcelaCompleta));
            }
        }
    }
}
