using SellTech.Infrastructure.FileStorage;

namespace SellTech.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestra interfaces a nivel de repository

        ICategoriaRepository Categoria { get; }
        IUsuarioRepository Usuario { get; }
        IAzureStorage Storage { get; }
        IProveedorRepository Proveedor { get; }
        ITipoDocumentoRepository TipoDocumento { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
