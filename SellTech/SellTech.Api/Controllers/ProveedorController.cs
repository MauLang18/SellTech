using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellTech.Application.Dtos.Proveedor.Request;
using SellTech.Application.Interfaces;
using SellTech.Infrastructure.Commons.Bases.Request;

namespace SellTech.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorApplication _proveedorApplication;

        public ProveedorController(IProveedorApplication proveedorApplication)
        {
            _proveedorApplication = proveedorApplication;
        }

        [HttpGet]
        public async Task<IActionResult> ListProveedores([FromQuery] BaseFiltersRequest filters)
        {
            var response = await _proveedorApplication.ListProveedores(filters);

            return Ok(response);
        }

        [HttpGet("{pkTblPosProveedor:int}")]
        public async Task<IActionResult> ProveedorById(int pkTblPosProveedor)
        {
            var response = await _proveedorApplication.ProveedorById(pkTblPosProveedor);

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterProveedor([FromBody] ProveedorRequestDto requestDto)
        {
            var response = await _proveedorApplication.RegisterProveedor(requestDto);

            return Ok(response);
        }

        [HttpPut("Edit/{pkTblPosProveedor:int}")]
        public async Task<IActionResult> EditProveedor(int pkTblPosProveedor, [FromBody] ProveedorRequestDto requestDto)
        {
            var response = await _proveedorApplication.EditProveedor(pkTblPosProveedor,requestDto);

            return Ok(response);
        }

        [HttpPut("Remove/{pkTblPosProveedor:int}")]
        public async Task<IActionResult> RemoveProveedor(int pkTblPosProveedor)
        {
            var response = await _proveedorApplication.RemoveProveedor(pkTblPosProveedor);

            return Ok(response);
        }
    }
}
