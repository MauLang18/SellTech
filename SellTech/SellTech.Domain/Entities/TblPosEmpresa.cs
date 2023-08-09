using System;
using System.Collections.Generic;

namespace SellTech.Domain.Entities;

public partial class TblPosEmpresa
{
    public int PkTblPosEmpresa { get; set; }

    public string Codigo { get; set; } = null!;

    public string CedulaJuridica { get; set; } = null!;

    public string NombreEmpresa { get; set; } = null!;

    public string Logo { get; set; } = null!;

    public int FkIdDistricto { get; set; }

    public string Direccion { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime FechaDeCreacion { get; set; }

    public string Telefono { get; set; } = null!;

    public string Vision { get; set; } = null!;

    public string Mision { get; set; } = null!;

    public int Estado { get; set; }

    public virtual TblPosDistricto FkIdDistrictoNavigation { get; set; } = null!;

    public virtual ICollection<TblPosSucursal> TblPosSucursals { get; set; } = new List<TblPosSucursal>();
}
