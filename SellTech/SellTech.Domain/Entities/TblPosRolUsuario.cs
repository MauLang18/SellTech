using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosRolUsuario
{
    public int PkTblPosRolUsuario { get; set; }

    public int FkIdRol { get; set; }

    public int FkIdUsuario { get; set; }

    public int FkIdSucursal { get; set; }

    public int Estado { get; set; }

    public virtual TblPosRol FkIdRolNavigation { get; set; } = null!;

    public virtual TblPosSucursal FkIdSucursalNavigation { get; set; } = null!;

    public virtual TblPosUsuario FkIdUsuarioNavigation { get; set; } = null!;
}
