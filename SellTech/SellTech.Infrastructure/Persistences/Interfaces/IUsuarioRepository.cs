using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<TblPosUsuario>
    {
        Task<TblPosUsuario> UserByEmail(string email);
    }
}
