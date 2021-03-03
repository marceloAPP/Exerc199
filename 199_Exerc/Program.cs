using System;
using System.Globalization;

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

            Console.Write("Valor do Contato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        }
    }
}
