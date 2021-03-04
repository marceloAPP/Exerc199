using System;
using System.Globalization;
using _199_Exerc.Entities;
using _199_Exerc.Services;

namespace _199_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os Dados do Contrato: ");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data (DD/MM/AAAA): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do Contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o número de parcelas: ");
            int quantMeses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);
            ServicoContrato servicoContrato = new ServicoContrato(new PaypalService());
            servicoContrato.ProcessarContrato(contrato, quantMeses);


            Console.WriteLine("\nPrestações: ");
            foreach (Prestacao item in contrato.Prestacoes)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            
        }
    }
}
