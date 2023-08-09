using AutoMapper;
using SellTech.Application.Dtos.Categoria.Request;
using SellTech.Application.Dtos.Categoria.Response;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Utilities.Static;

namespace SellTech.Application.Mappers
{
    public class CategoriaMappingsProfile : Profile
    {
        public CategoriaMappingsProfile()
        {
            CreateMap<TblPosCategorium, CategoriaResponseDto>()
                .ForMember(x => x.PkTblPosCategoria, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.EstadoCategoria, x => x.MapFrom(y => y.Estado.Equals((int)StateTypes.Activo) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<BaseEntityResponse<TblPosCategorium>, BaseEntityResponse<CategoriaResponseDto>>()
                .ReverseMap();

            CreateMap<CategoriaRequestDto, TblPosCategorium>();

            CreateMap<TblPosCategorium, CategoriaSelectResponseDto>()
                .ForMember(x => x.PkTblPosCategoria, x => x.MapFrom(y => y.Id))
                .ReverseMap();
        }
    }
}