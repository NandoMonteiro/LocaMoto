namespace LocaMoto.Models.DTOs
{
    public class LocacaoDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int MotoId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime HoraRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime Horadevolucao { get; set; }

        public decimal ValorLocacao { get; set; }

        public decimal ValorDesconto { get; set; }
        public int QuilometragemInicial { get; set; }
        public int QuilometragemFinal { get; set; }

        public string Observacao { get; set; } = string.Empty;
        public enum StatusLocacao
        {
            Pendente,
            Emandamento,
            Concluida,
            Cancelada
        }

        public decimal ValorServico { get; set; }


        public decimal ValorItem { get; set; }

        public decimal ValorItemTotal { get; set; }

        public decimal Valortotallocacao { get; set; }
    }
}
