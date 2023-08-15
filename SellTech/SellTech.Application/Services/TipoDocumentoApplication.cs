using AutoMapper;
using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.TipoDocumento.Response;
using SellTech.Application.Interfaces;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Utilities.Static;
using WatchDog;

namespace SellTech.Application.Services
{
    public class TipoDocumentoApplication : ITipoDocumentoApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoDocumentoApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<IEnumerable<TipoDocumentoResponseDto>>> ListTipoDocumentos()
        {
            var response = new BaseResponse<IEnumerable<TipoDocumentoResponseDto>>();

            try
            {
                var tipoDocuemnto = await _unitOfWork.TipoDocumento.ListTipoDocumentos();

                if(tipoDocuemnto is not null)
                {
                    response.Data = _mapper.Map<IEnumerable<TipoDocumentoResponseDto>>(tipoDocuemnto);
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
    }
}
