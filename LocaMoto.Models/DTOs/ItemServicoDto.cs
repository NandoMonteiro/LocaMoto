using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocaMoto.Models.DTOs
{
    public class ItemServicoDto
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        public decimal Valor { get; set; }
    }
}
