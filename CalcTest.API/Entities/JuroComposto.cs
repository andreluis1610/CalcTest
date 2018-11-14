using CalcTest.API.Exceptions;

namespace CalcTest.API.Entities
{
    public class JuroComposto
    {
        /// <summary>
        /// Valor inicial considerado base para o cálculo dos juros.
        /// </summary>
        public double ValorInicial { get; set; }
        /// <summary>
        /// Quantidade de meses.
        /// </summary>
        public int QuantidadeMeses { get; set; }
        /// <summary>
        /// Percentual da taxa de juros.
        /// </summary>
        public readonly double TaxaDeJuros = 0.01;

        public JuroComposto(double valorInicial, int quantidadeMeses)
        {
            ValorInicial = valorInicial;
            QuantidadeMeses = quantidadeMeses;
        }

        /// <summary>
        /// Método responsável por validar se os atributos essenciais para o cálculo são válidos.
        /// </summary>
        public void ehValido()
        {
            if(ValorInicial < 0 || QuantidadeMeses < 0)
            {
                throw new ParametrosInvalidosException();
            }
        }
    }
}
