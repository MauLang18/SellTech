using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellTech.Application.Dtos.Categoria.Request;
using SellTech.Application.Interfaces;
using SellTech.Infrastructure.Commons.Bases.Request;

namespace SellTech.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaApplication _categoriaApplication;

        public CategoriaController(ICategoriaApplication categoriaApplication)
        {
            _categoriaApplication = categoriaApplication;
        }

        [HttpPost]
        public async Task<IActionResult> ListCategorias([FromBody] BaseFiltersRequest filters)
        {
            var response = await _categoriaApplication.ListCategorias(filters);

            return Ok(response);
        }

        [HttpGet("Select")]
        public async Task<IActionResult> ListSelectCategorias()
        {
            var response = await _categoriaApplication.ListSelectCategorias();

            return Ok(response);
        }

        [HttpGet("{pkTblPosCategoria:int}")]
        public async Task<IActionResult> CategoriaById(int pkTblPosCategoria)
        {
            var response = await _categoriaApplication.CategoriaById(pkTblPosCategoria);

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterCategoria([FromBody] CategoriaRequestDto requestDto)
        {
            var response = await _categoriaApplication.RegisterCategoria(requestDto);

            return Ok(response);
        }

        [HttpPut("Edit/{pkTblPosCategoria:int}")]
        public async Task<IActionResult> EditCategoria(int pkTblPosCategoria, [FromBody] CategoriaRequestDto requestDto)
        {
            var response = await _categoriaApplication.EditCategoria(pkTblPosCategoria,requestDto);

            return Ok(response);
        }

        [HttpPut("Remove/{pkTblPosCategoria:int}")]
        public async Task<IActionResult> RemoveCategoria(int pkTblPosCategoria)
        {
            var response = await _categoriaApplication.RemoveCategoria(pkTblPosCategoria);

            return Ok(response);
        }
    }
}
