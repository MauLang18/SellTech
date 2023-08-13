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

        public async Task<TblPosUsuario> UserByEmail(string email)
        {
            var user = await _context.TblPosUsuarios.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Correo!.Equals(email));

            return user;
        }
    }
}
