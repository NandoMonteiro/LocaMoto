namespace LocaMoto.Models.DTOs
{
    public class LocacaoItemDto
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }
        public int ItemServicoId { get; set; }

        public decimal Quantidade { get; set; }
    }
}
