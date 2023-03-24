using Ex_013_CalculadoraAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ex_013_CalculadoraAPI.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("Somar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Somar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.somar();
            return Ok(calc);
        }
    }
}
