using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinhaAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("/calculaJuros/{valorInicial}/{meses}")]
        public ActionResult<string> ObterTaxaJuros(decimal valorInicial, int meses)
        {
            var juros = new TaxaJuros().Juros;

            var resultado = Math.Round(valorInicial * (decimal)Math.Pow(1 + juros, meses), 2, MidpointRounding.AwayFromZero);

            return resultado.ToString();
        }

        [HttpGet("/showMeTheCode")]
        public ActionResult<string> Get()
        {
            return "https://github.com/diegohiguchi/CalcTest";
        }
    }
}