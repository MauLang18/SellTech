using Microsoft.AspNetCore.Http;

namespace SellTech.Application.Dtos.Usuario.Request
{
    public class UsuarioRequestDto
    {
        public string? Username { get; set; }

        public string? Pass { get; set; } 

        public string? Correo { get; set; } 

        public IFormFile? Imagen { get; set; }

        public string? AuthType { get; set; }

        public int? Estado { get; set; }
    }
}
