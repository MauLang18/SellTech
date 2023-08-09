using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosProvincium
{
    public int PkTblPosProvincia { get; set; }

    public string Nombre { get; set; } = null!;

    public int FkIdDepartamento { get; set; }

    public int Estado { get; set; }

    public virtual TblPosDepartamento FkIdDepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<TblPosDistricto> TblPosDistrictos { get; set; } = new List<TblPosDistricto>();
}
