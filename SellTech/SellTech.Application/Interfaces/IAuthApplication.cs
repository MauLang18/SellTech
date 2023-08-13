using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Usuario.Request;

namespace SellTech.Application.Interfaces
{
    public interface IAuthApplication
    {
        Task<BaseResponse<string>> Login(TokenRequestDto requestDto, string authType);
        Task<BaseResponse<string>> LoginWithGoogle(string credentials, string authType);
    }
}
