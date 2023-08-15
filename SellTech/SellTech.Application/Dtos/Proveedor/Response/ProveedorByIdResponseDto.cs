namespace SellTech.Application.Dtos.Proveedor.Response
{
    public class ProveedorByIdResponseDto
    {
        public int PkTblPosProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public int? FkIdTipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int Estado { get; set; }
    }
}
