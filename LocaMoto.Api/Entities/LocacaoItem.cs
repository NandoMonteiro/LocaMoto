using System.ComponentModel.DataAnnotations.Schema;

namespace LocaMoto.Api.Entities
{
    public class LocacaoItem
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }
        public int ItemServicoId { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Quantidade { get; set; }

        public Locacao? Locacao { get; set; }
        public ItemServico? ItemServico { get; set; }
    }
}
