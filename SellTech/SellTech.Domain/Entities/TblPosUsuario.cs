namespace SellTech.Domain.Entities;

public partial class TblPosUsuario : BaseEntity
{
    public string? Username { get; set; }

    public string? Pass { get; set; }

    public string? Correo { get; set; }

    public string? Imagen { get; set; }

    public string? AuthType { get; set; }

    public virtual ICollection<TblPosCompra> TblPosCompras { get; set; } = new List<TblPosCompra>();

    public virtual ICollection<TblPosRolUsuario> TblPosRolUsuarios { get; set; } = new List<TblPosRolUsuario>();

    public virtual ICollection<TblPosUsuarioSucursal> TblPosUsuarioSucursals { get; set; } = new List<TblPosUsuarioSucursal>();

    public virtual ICollection<TblPosVentum> TblPosVenta { get; set; } = new List<TblPosVentum>();
}
