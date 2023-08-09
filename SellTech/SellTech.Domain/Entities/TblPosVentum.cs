using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosVentum
{
    public int PkTblPosVenta { get; set; }

    public int FkIdCliente { get; set; }

    public int FkIdUsuario { get; set; }

    public DateTime FechaVenta { get; set; }

    public decimal? Impuesto { get; set; }

    public decimal? Total { get; set; }

    public int UsuarioCreacionAuditoria { get; set; }

    public DateTime FechaCreacionAuditoria { get; set; }

    public int? UsuarioActualizacionAuditoria { get; set; }

    public DateTime? FechaActualizacionAuditoria { get; set; }

    public int? UsuarioEliminacionAuditoria { get; set; }

    public DateTime? FechaEliminacionAuditoria { get; set; }

    public int Estado { get; set; }

    public virtual TblPosCliente FkIdClienteNavigation { get; set; } = null!;

    public virtual TblPosUsuario FkIdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<TblPosDetalleVentum> TblPosDetalleVenta { get; set; } = new List<TblPosDetalleVentum>();
}
