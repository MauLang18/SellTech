using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Usuario.Request;

namespace SellTech.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        Task<BaseResponse<bool>> RegisterUsuario(UsuarioRequestDto requestDto);
    }
}
