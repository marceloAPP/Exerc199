﻿using System;
using System.Collections.Generic;

namespace _199_Exerc.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacoes { get; set; }


        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacao>();
        }

        public void AdicionaPrestacoes(Prestacao prestacoes)
        {
            Prestacoes.Add(prestacoes);
        }
    }
}
