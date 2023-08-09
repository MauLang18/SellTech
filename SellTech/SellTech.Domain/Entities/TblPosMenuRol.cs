using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosMenuRol
{
    public int PkTblPosMenuRol { get; set; }

    public int FkIdRol { get; set; }

    public int FkIdMenu { get; set; }

    public int Estado { get; set; }

    public virtual TblPosMenu FkIdMenuNavigation { get; set; } = null!;

    public virtual TblPosRol FkIdRolNavigation { get; set; } = null!;
}
