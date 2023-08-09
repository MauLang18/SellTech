using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosDepartamento
{
    public int PkTblPosDepartamento { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<TblPosProvincium> TblPosProvincia { get; set; } = new List<TblPosProvincium>();
}
