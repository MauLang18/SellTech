using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosDistricto
{
    public int PkTblPosDistricto { get; set; }

    public string Nombre { get; set; } = null!;

    public int FkIdProvincia { get; set; }

    public int Estado { get; set; }

    public virtual TblPosProvincium FkIdProvinciaNavigation { get; set; } = null!;

    public virtual ICollection<TblPosEmpresa> TblPosEmpresas { get; set; } = new List<TblPosEmpresa>();

    public virtual ICollection<TblPosSucursal> TblPosSucursals { get; set; } = new List<TblPosSucursal>();
}
