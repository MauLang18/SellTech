using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;

namespace SellTech.Infrastructure.Persistences.Interfaces
{
    public interface IProveedorRepository : IGenericRepository<TblPosProveedor>
    {
        Task<BaseEntityResponse<TblPosProveedor>> ListProveedores(BaseFiltersRequest filters);
    }
}
