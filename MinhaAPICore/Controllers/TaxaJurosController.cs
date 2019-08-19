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
    public class TaxaJurosController : ControllerBase
    {
        // GET: api/TaxaJuros
        [HttpGet("/taxaJuros")]
        public ActionResult<double> ObterTaxaJuros()
        {
            return new TaxaJuros().Juros;
        }
    }
}
