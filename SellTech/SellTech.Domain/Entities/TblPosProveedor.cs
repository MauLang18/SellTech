namespace SellTech.Domain.Entities;

public partial class TblPosProveedor : BaseEntity
{
    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int FkIdTipoDocumento { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string? Direccion { get; set; }

    public string Telefono { get; set; } = null!;

    public virtual TblPosTipoDocumento FkIdTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<TblPosCompra> TblPosCompras { get; set; } = new List<TblPosCompra>();

    public virtual ICollection<TblPosProducto> TblPosProductos { get; set; } = new List<TblPosProducto>();
}
