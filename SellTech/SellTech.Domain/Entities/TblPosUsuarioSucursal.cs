using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosUsuarioSucursal
{
    public int PkTblPosUsuarioSucursal { get; set; }

    public int FkIdSucursal { get; set; }

    public int FkIdUsuario { get; set; }

    public int Estado { get; set; }

    public virtual TblPosSucursal FkIdSucursalNavigation { get; set; } = null!;

    public virtual TblPosUsuario FkIdUsuarioNavigation { get; set; } = null!;
}
