using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Models.DTOs
{
    public class CategoriaDto
    {
        public int Id { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;
    }
}
