using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.TipoDocumento.Response;

namespace SellTech.Application.Interfaces
{
    public interface ITipoDocumentoApplication
    {
        Task<BaseResponse<IEnumerable<TipoDocumentoResponseDto>>> ListTipoDocumentos();
    }
}
