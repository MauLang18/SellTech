using AutoMapper;
using SellTech.Application.Dtos.Proveedor.Request;
using SellTech.Application.Dtos.Proveedor.Response;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Utilities.Static;

namespace SellTech.Application.Mappers
{
    public class ProveedorMappingsProfile : Profile
    {
        public ProveedorMappingsProfile()
        {
            CreateMap<TblPosProveedor, ProveedorResponseDto>()
                .ForMember(x => x.PkTblPosProveedor, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.TipoDocumento, x => x.MapFrom(y => y.FkIdTipoDocumentoNavigation.Abreviacion))
                .ForMember(x => x.EstadoProveedor, x => x.MapFrom(y => y.Estado.Equals((int)StateTypes.Activo) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<TblPosProveedor, ProveedorByIdResponseDto>()
                .ForMember(x => x.PkTblPosProveedor, x => x.MapFrom(y => y.Id))
                .ReverseMap();

            CreateMap<BaseEntityResponse<TblPosProveedor>, BaseEntityResponse<ProveedorResponseDto>>().
                ReverseMap();

            CreateMap<ProveedorRequestDto, TblPosProveedor>();
        }
    }
}
