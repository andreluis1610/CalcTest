using CalcTest.API.Exceptions;
using CalcTest.API.Interfaces;
using System;

namespace CalcTest.API.Entities
{
    public class JuroComposto : Calculo
    {
        public double ValorInicial { get; set; }
        public int QuantidadeMeses { get; set; }
        private readonly double _taxaDeJuros = 0.01;

        public JuroComposto(double valorInicial, int quantidadeMeses)
        {
            ValorInicial = valorInicial;
            QuantidadeMeses = quantidadeMeses;
        }

        public string Calcular()
        {
            double valorFinal = ValorInicial * Math.Pow(1 + _taxaDeJuros, QuantidadeMeses);
            valorFinal = Math.Truncate(100 * valorFinal) / 100;

            if (valorFinal > double.MaxValue)
                throw new DoubleInfinityException();

            return valorFinal.ToString("F");
        }
    }
}
