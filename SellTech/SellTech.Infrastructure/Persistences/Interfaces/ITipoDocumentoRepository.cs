using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Interfaces
{
    public interface ITipoDocumentoRepository
    {
        Task<IEnumerable<TblPosTipoDocumento>> ListTipoDocumentos();
    }
}
