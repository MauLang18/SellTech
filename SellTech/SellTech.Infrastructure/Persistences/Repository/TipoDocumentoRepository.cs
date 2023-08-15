using Microsoft.EntityFrameworkCore;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Utilities.Static;

namespace SellTech.Infrastructure.Persistences.Repository
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly BdPosContext _context;

        public TipoDocumentoRepository(BdPosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPosTipoDocumento>> ListTipoDocumentos()
        {
            var tipoDocumentos = await _context.TblPosTipoDocumentos
                .Where(x => x.Estado.Equals((int)StateTypes.Activo))
                .AsNoTracking()
                .ToListAsync();

            return tipoDocumentos;
        }
    }
}
