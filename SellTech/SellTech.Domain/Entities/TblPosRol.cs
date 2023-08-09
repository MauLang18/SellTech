using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosRol
{
    public int PkTblPosRol { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<TblPosMenuRol> TblPosMenuRols { get; set; } = new List<TblPosMenuRol>();

    public virtual ICollection<TblPosRolUsuario> TblPosRolUsuarios { get; set; } = new List<TblPosRolUsuario>();
}
