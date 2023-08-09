using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Proveedor.Request;
using SellTech.Application.Dtos.Proveedor.Response;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;

namespace SellTech.Application.Interfaces
{
    public interface IProveedorApplication
    {
        Task<BaseResponse<BaseEntityResponse<ProveedorResponseDto>>> ListProveedores(BaseFiltersRequest filters);
        Task<BaseResponse<ProveedorResponseDto>> ProveedorById(int pkTblPosProveedor);
        Task<BaseResponse<bool>> RegisterProveedor(ProveedorRequestDto requestDto);
        Task<BaseResponse<bool>> EditProveedor(int pkTblPosProveedor, ProveedorRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveProveedor(int pkTblPosProveedor);
    }
}
