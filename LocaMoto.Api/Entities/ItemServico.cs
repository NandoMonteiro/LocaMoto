using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class ItemServico
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        public ICollection<LocacaoItem> Item { get; set; }
            = new List<LocacaoItem>();
    }
}
