using AutoMapper;
using SellTech.Application.Dtos.Usuario.Request;
using SellTech.Domain.Entities;

namespace SellTech.Application.Mappers
{
    public class UsuarioMappingsProfile : Profile
    {
        public UsuarioMappingsProfile()
        {
            CreateMap<UsuarioRequestDto, TblPosUsuario>();
            CreateMap<TokenRequestDto, TblPosUsuario>();
        }
    }
}
