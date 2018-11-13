using CalcTest.API.Entities;
using CalcTest.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalcTest.API.Controllers
{
    /// <summary>
    /// Classe controladora das operações de cálculo de juros compostos.
    /// </summary>
    public class CalcTestController : Controller
    {
        /// <summary>
        /// Método responsável por realizar o cálculo de juros compostos.
        /// </summary>
        /// <param name="valorInicial">Valor Inicial.</param>
        /// <param name="meses">Quantidade de meses.</param>
        /// <returns>Resultado do cálculo de juros compostos.</returns>
        [HttpGet("api/calculajuros/{valorInicial}/{meses}")]
        public string CalculaJuros(decimal valorInicial, int meses)
        {
            Calculo calculo = new JuroComposto(Convert.ToDouble(valorInicial), meses);
            return calculo.Calcular();
        }
    }
}
