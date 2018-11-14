using CalcTest.API.Entities;
using CalcTest.API.Exceptions;
using CalcTest.API.Interfaces;
using System;

namespace CalcTest.API.Services
{
    public class JuroCompostoService : Calculo
    {
        private readonly JuroComposto _juroComposto;

        public JuroCompostoService(JuroComposto juroComposto)
        {
            _juroComposto = juroComposto;
        }

        /// <summary>
        /// Método responsável por realizar o cálculo dos juros compostos.
        /// </summary>
        /// <returns>Valor final com o acréscimo dos juros.</returns>
        public string Calcular()
        {
            double valorFinal = _juroComposto.ValorInicial * Math.Pow(1 + _juroComposto.TaxaDeJuros, _juroComposto.QuantidadeMeses);
            valorFinal = Math.Truncate(100 * valorFinal) / 100;

            if(valorFinal > double.MaxValue)
            {
                throw new DoubleInvalidoException();
            }

            return valorFinal.ToString("F");
        }
    }
}
