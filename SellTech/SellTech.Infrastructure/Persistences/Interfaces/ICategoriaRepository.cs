using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;

namespace SellTech.Infrastructure.Persistences.Interfaces
{
    public interface ICategoriaRepository : IGenericRepository<TblPosCategorium>
    {
        Task<BaseEntityResponse<TblPosCategorium>> ListCategorias(BaseFiltersRequest filters);
    }
}
