using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosDetalleCompra
{
    public int PkTblPosDetalleCompra { get; set; }

    public int FkIdCompra { get; set; }

    public int FkIdProducto { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public int UsuarioCreacionAuditoria { get; set; }

    public DateTime FechaCreacionAuditoria { get; set; }

    public int? UsuarioActualizacionAuditoria { get; set; }

    public DateTime? FechaActualizacionAuditoria { get; set; }

    public int? UsuarioEliminacionAuditoria { get; set; }

    public DateTime? FechaEliminacionAuditoria { get; set; }

    public virtual TblPosCompra FkIdCompraNavigation { get; set; } = null!;

    public virtual TblPosProducto FkIdProductoNavigation { get; set; } = null!;
}
