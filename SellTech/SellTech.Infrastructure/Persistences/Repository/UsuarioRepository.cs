using Microsoft.EntityFrameworkCore;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;

namespace SellTech.Infrastructure.Persistences.Repository
{
    public class UsuarioRepository : GenericRepository<TblPosUsuario>, IUsuarioRepository
    {
        private readonly BdPosContext _context;
        public UsuarioRepository(BdPosContext context) : base(context)
        {
            _context = context;
        }

        public async Task<TblPosUsuario> AccountByUserName(string userName)
        {
            var account = await _context.TblPosUsuarios.AsNoTracking().FirstOrDefaultAsync(x => x.Username!.Equals(userName));

            return account;
        }
    }
}
