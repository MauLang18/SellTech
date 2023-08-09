namespace SellTech.Application.Dtos.Proveedor.Response
{
    public class ProveedorResponseDto
    {
        public int PkTblPosProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public DateTime? FechaCreacionAuditoria { get; set; }
        public int Estado { get; set; }
        public string? EstadoProveedor { get; set; }
    }
}
