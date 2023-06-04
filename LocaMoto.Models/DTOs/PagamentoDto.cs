namespace LocaMoto.Models.DTOs
{
    public class PagamentoDto
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }


        public string NumeroCartao { get; set; }


        public string NomeTitular { get; set; }
        public DateTime DataValidade { get; set; }

        public string CVV { get; set; }

        public string BandeiraCartao { get; set; }

        public decimal ValorPagamento { get; set; }
        public DateTime DadaHoraPagamento { get; set; }


    }
}
