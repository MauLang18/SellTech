using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosMenu
{
    public int PkTblPosMenu { get; set; }

    public string? Nombre { get; set; }

    public string? Icono { get; set; }

    public string Urls { get; set; } = null!;

    public int IdPadre { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<TblPosMenuRol> TblPosMenuRols { get; set; } = new List<TblPosMenuRol>();
}
