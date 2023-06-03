using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class Pagamento
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }

        [MaxLength(16)]
        public string NumeroCartao { get; set; } = string.Empty;

        [MaxLength(20)]
        public string NomeTitular { get; set; } = string.Empty;
        public DateTime DataValidade { get; set; }

        [MaxLength(3)]
        public string CVV { get; set; } = string.Empty;

        [MaxLength(20)]
        public string BandeiraCartao { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorPagamento { get; set; }
        public DateTime DadaHoraPagamento { get; set; }

        public Locacao? Locacao { get; set; }
    }
}
