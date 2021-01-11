using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Api2Controller : ApiBase
    {
        private readonly IJurosService _service;

        public Api2Controller(IJurosService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("showmethecode")]
        public async Task<IActionResult> ShowMeTheCode()
        {
            return Response(await _service.ShowMeTheCode());
        }
       
        [HttpGet]
        [Route("calculajuros/{valorInicial:decimal}/{meses:int}")]
        public async Task<IActionResult> CalcularJuros(decimal valorInicial, int meses)
        {
            return Response(await _service.CalcularJuros(valorInicial, meses));
        }
    }
}
