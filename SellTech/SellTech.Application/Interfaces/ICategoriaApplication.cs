using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Categoria.Request;
using SellTech.Application.Dtos.Categoria.Response;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;

namespace SellTech.Application.Interfaces
{
    public interface ICategoriaApplication
    {
        Task<BaseResponse<BaseEntityResponse<CategoriaResponseDto>>> ListCategorias(BaseFiltersRequest filters);
        Task<BaseResponse<IEnumerable<CategoriaSelectResponseDto>>> ListSelectCategorias();
        Task<BaseResponse<CategoriaResponseDto>> CategoriaById(int pkTblPosCategoria);
        Task<BaseResponse<bool>> RegisterCategoria(CategoriaRequestDto requestDto);
        Task<BaseResponse<bool>> EditCategoria(int pkTblPosCategoria, CategoriaRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveCategoria(int pkTblPosCategoria);
    }
}
