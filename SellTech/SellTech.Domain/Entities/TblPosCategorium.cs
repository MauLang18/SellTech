namespace SellTech.Domain.Entities;

public partial class TblPosCategorium : BaseEntity
{
    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<TblPosProducto> TblPosProductos { get; set; } = new List<TblPosProducto>();
}
