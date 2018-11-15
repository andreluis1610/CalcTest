using Microsoft.AspNetCore.Mvc;

namespace CalcTest.Controllers
{
    /// <summary>
    /// Classe responsável por gerenciar o código do proje 
    /// </summary>
    public class CodeController : Controller
    {
        /// <summary>
        /// Retorna o link do Github onde se encontra o código do projeto CalcTest.
        /// </summary>
        /// <returns>Url de acesso ao código fonte do projeto.</returns>
        [HttpGet("api/showmethecode")]
        public string GetUrlCode()
        {
            return "https://github.com/andreluis1610/CalcTest";
        }
    }
}
