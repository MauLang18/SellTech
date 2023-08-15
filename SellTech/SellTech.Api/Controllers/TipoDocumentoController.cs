using Microsoft.AspNetCore.Mvc;
using SellTech.Application.Interfaces;

namespace SellTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITipoDocumentoApplication _tipoDocumentoApplication;

        public TipoDocumentoController(ITipoDocumentoApplication tipoDocumentoApplication)
        {
            this._tipoDocumentoApplication = tipoDocumentoApplication;
        }

        [HttpGet]
        public async Task<IActionResult> ListTipoDocumentos()
        {
            var response = await _tipoDocumentoApplication.ListTipoDocumentos();

            return Ok(response);
        }
    }
}
