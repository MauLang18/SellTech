using AutoMapper;
using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Usuario.Request;
using SellTech.Application.Interfaces;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Utilities.Static;
using WatchDog;
using BC = BCrypt.Net.BCrypt;

namespace SellTech.Application.Services
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsuarioApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> RegisterUsuario(UsuarioRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();

            try
            {
                var account = _mapper.Map<TblPosUsuario>(requestDto);
                account.Pass = BC.HashPassword(account.Pass);

                if (requestDto.Imagen is not null)
                {
                    account.Imagen = await _unitOfWork.Storage.SaveFile(AzureContainers.USUARIOS, requestDto.Imagen);
                }

                response.Data = await _unitOfWork.Usuario.RegisterAsync(account);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_SAVE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
    }
}
