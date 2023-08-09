using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosProducto
{
    public int PkTblPosProducto { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int Stock { get; set; }

    public string? Imagen { get; set; }

    public decimal Precio { get; set; }

    public int FkIdCategoria { get; set; }

    public int FkIdProveedor { get; set; }

    public int UsuarioCreacionAuditoria { get; set; }

    public DateTime FechaCreacionAuditoria { get; set; }

    public int? UsuarioActualizacionAuditoria { get; set; }

    public DateTime? FechaActualizacionAuditoria { get; set; }

    public int? UsuarioEliminacionAuditoria { get; set; }

    public DateTime? FechaEliminacionAuditoria { get; set; }

    public int Estado { get; set; }

    public virtual TblPosCategorium FkIdCategoriaNavigation { get; set; } = null!;

    public virtual TblPosProveedor FkIdProveedorNavigation { get; set; } = null!;

    public virtual ICollection<TblPosDetalleCompra> TblPosDetalleCompras { get; set; } = new List<TblPosDetalleCompra>();

    public virtual ICollection<TblPosDetalleVentum> TblPosDetalleVenta { get; set; } = new List<TblPosDetalleVentum>();
}
