namespace SellTech.Application.Dtos.Categoria.Response
{
    public class CategoriaResponseDto
    {
        public long PkTblPosCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fechacreacionauditoria { get; set; }
        public int Estado { get; set; }
        public string? EstadoCategoria { get; set; }
    }
}
