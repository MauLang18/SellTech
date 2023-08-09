using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosDetalleVentum
{
    public int PkTblPosDetalleVenta { get; set; }

    public int FkIdVenta { get; set; }

    public int FkIdProducto { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal? Descuento { get; set; }

    public int UsuarioCreacionAuditoria { get; set; }

    public DateTime FechaCreacionAuditoria { get; set; }

    public int? UsuarioActualizacionAuditoria { get; set; }

    public DateTime? FechaActualizacionAuditoria { get; set; }

    public int? UsuarioEliminacionAuditoria { get; set; }

    public DateTime? FechaEliminacionAuditoria { get; set; }

    public virtual TblPosProducto FkIdProductoNavigation { get; set; } = null!;

    public virtual TblPosVentum FkIdVentaNavigation { get; set; } = null!;
}
