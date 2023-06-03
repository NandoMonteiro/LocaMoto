using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Tipo { get; set; } = string.Empty;

        [MaxLength(900)]
        public string Descricao { get; set; } = string.Empty;

        public Collection<Moto> Motos { get; set; }
              = new Collection<Moto>();
    }
}
