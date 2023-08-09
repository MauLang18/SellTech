using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosSucursal
{
    public int PkTblPosSucursal { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int FkIdEmpresa { get; set; }

    public string Descripcion { get; set; } = null!;

    public int FkIdDistricto { get; set; }

    public string Direccion { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int Estado { get; set; }

    public virtual TblPosDistricto FkIdDistrictoNavigation { get; set; } = null!;

    public virtual TblPosEmpresa FkIdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TblPosRolUsuario> TblPosRolUsuarios { get; set; } = new List<TblPosRolUsuario>();

    public virtual ICollection<TblPosUsuarioSucursal> TblPosUsuarioSucursals { get; set; } = new List<TblPosUsuarioSucursal>();
}
