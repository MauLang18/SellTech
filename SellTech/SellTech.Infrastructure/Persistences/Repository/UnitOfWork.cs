using Microsoft.Extensions.Configuration;
using SellTech.Infrastructure.FileStorage;
using SellTech.Infrastructure.Persistences.Contexts;
using SellTech.Infrastructure.Persistences.Interfaces;

namespace SellTech.Infrastructure.Persistences.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BdPosContext _context;
        public ICategoriaRepository Categoria { get; private set; }

        public IUsuarioRepository Usuario { get; private set; }

        public IAzureStorage Storage { get; private set; }

        public IProveedorRepository Proveedor { get; private set; }

        public UnitOfWork(BdPosContext context, IConfiguration configuration)
        {
            _context = context;
            Categoria = new CategoriaRepository(_context);
            Usuario = new UsuarioRepository(_context);
            Storage = new AzureStorage(configuration);
            Proveedor = new ProveedorRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
