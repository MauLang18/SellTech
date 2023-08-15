using AutoMapper;
using SellTech.Application.Dtos.TipoDocumento.Response;
using SellTech.Domain.Entities;

namespace SellTech.Application.Mappers
{
    public class TipoDocumentosMappingsProfile : Profile
    {
        public TipoDocumentosMappingsProfile()
        {
            CreateMap<TblPosTipoDocumento, TipoDocumentoResponseDto>()
                .ReverseMap();
        }
    }
}
