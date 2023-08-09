using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosCliente
{
    public int PkTblPosCliente { get; set; }

    public string? Nombre { get; set; }

    public int FkIdTipoDocumento { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int UsuarioCreacionAuditoria { get; set; }

    public DateTime FechaCreacionAuditoria { get; set; }

    public int? UsuarioActualizacionAuditoria { get; set; }

    public DateTime? FechaActualizacionAuditoria { get; set; }

    public int? UsuarioEliminacionAuditoria { get; set; }

    public DateTime? FechaEliminacionAuditoria { get; set; }

    public int Estado { get; set; }

    public virtual TblPosTipoDocumento FkIdTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<TblPosVentum> TblPosVenta { get; set; } = new List<TblPosVentum>();
}
