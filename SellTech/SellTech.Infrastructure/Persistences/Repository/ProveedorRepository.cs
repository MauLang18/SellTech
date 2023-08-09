using Microsoft.EntityFrameworkCore;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;

namespace SellTech.Infrastructure.Persistences.Repository
{
    public class ProveedorRepository : GenericRepository<TblPosProveedor>, IProveedorRepository
    {
        public ProveedorRepository(BdPosContext context): base (context)
        {
            
        }

        public async Task<BaseEntityResponse<TblPosProveedor>> ListProveedores(BaseFiltersRequest filters)
        {
            var response = new BaseEntityResponse<TblPosProveedor>();

            var proveedores = GetEntityQuery(x => x.UsuarioEliminacionAuditoria == null && x.FechaEliminacionAuditoria == null)
                .Include(x => x.FkIdTipoDocumentoNavigation)
                .AsNoTracking();

            if(filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        proveedores = proveedores.Where(x => x.Nombre.Contains(filters.TextFilter));
                        break;
                    case 2:
                        proveedores = proveedores.Where(x => x.Correo.Contains(filters.TextFilter));
                        break;
                    case 3:
                        proveedores = proveedores.Where(x => x.NumeroDocumento.Contains(filters.TextFilter));
                        break;
                }
            }

            if(filters.StateFilter is not null)
            {
                proveedores = proveedores.Where(x => x.Estado.Equals(filters.StateFilter));
            }

            if(filters.StartDate is not null && filters.EndDate is not null)
            {
                proveedores = proveedores.Where(x => x.FechaCreacionAuditoria >= Convert.ToDateTime(filters.StartDate) && x.FechaCreacionAuditoria <= Convert.ToDateTime(filters.EndDate).AddDays(1));
            }

            if (filters.Sort is null) filters.Sort = "Id";

            response.TotalRecords = await proveedores.CountAsync();
            response.Items = await Ordering(filters, proveedores, !(bool)filters.Download!).ToListAsync();

            return response;
        }
    }
}
