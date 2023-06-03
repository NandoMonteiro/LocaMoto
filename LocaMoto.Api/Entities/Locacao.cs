using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class Locacao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int MotoId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime HoraRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime Horadevolucao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorLocacao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorDesconto { get; set; }
        public int QuilometragemInicial { get; set; }
        public int QuilometragemFinal { get; set; }

        [MaxLength(300)]
        public string Observacao { get; set; } = string.Empty;
        public enum StatusLocacao
        {
            Pendente,
            Emandamento,
            Concluida,
            Cancelada
        }

        public Moto? Moto { get; set; }
        public Cliente? Clientes { get; set; }
        

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorServico { get; set; }

      
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorItem { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorItemTotal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valortotallocacao { get; set; }

        public ICollection<LocacaoItem> Item { get; set; }
            = new List<LocacaoItem>();
    }
}
