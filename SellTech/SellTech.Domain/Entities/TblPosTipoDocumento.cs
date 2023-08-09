using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosTipoDocumento
{
    public int PkTblPosTipoDocumento { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Abreviacion { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<TblPosCliente> TblPosClientes { get; set; } = new List<TblPosCliente>();

    public virtual ICollection<TblPosProveedor> TblPosProveedors { get; set; } = new List<TblPosProveedor>();
}
