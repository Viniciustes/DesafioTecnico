using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class Api1Controller : ApiBase
    {
        private readonly IJurosService _service;

        public Api1Controller(IJurosService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("taxaJuros")]
        public async Task<IActionResult> BuscarTaxaJuros()
        {
            return Response(await _service.BuscarTaxaJuros());
        }
    }
}
