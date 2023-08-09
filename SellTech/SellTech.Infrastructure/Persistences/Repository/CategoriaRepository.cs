using Microsoft.EntityFrameworkCore;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;

namespace SellTech.Infrastructure.Persistences.Repository
{
    public class CategoriaRepository : GenericRepository<TblPosCategorium>, ICategoriaRepository
    {
        public CategoriaRepository(BdPosContext context) : base(context) { }

        public async Task<BaseEntityResponse<TblPosCategorium>> ListCategorias(BaseFiltersRequest filters)
        {
            var response = new BaseEntityResponse<TblPosCategorium>();

            var categorias = GetEntityQuery(x => x.UsuarioEliminacionAuditoria == null && x.FechaEliminacionAuditoria == null)
                .AsNoTracking();

            if (filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        categorias = categorias.Where(x => x.Nombre!.Contains(filters.TextFilter));
                        break;
                    case 2:
                        categorias = categorias.Where(x => x.Descripcion!.Contains(filters.TextFilter));
                        break;
                }
            }

            if (filters.StateFilter is not null)
            {
                categorias = categorias.Where(x => x.Estado.Equals(filters.StateFilter));
            }

            if (!string.IsNullOrEmpty(filters.StartDate) && !string.IsNullOrEmpty(filters.EndDate))
            {
                categorias = categorias.Where(x => x.FechaCreacionAuditoria >= Convert.ToDateTime(filters.StartDate) && x.FechaCreacionAuditoria <= Convert.ToDateTime(filters.EndDate).AddDays(1));
            }

            if (filters.Sort is null) filters.Sort = "Id";

            response.TotalRecords = await categorias.CountAsync();
            response.Items = await Ordering(filters, categorias, !(bool)filters.Download!).ToListAsync();

            return response;
        }
    }
}
