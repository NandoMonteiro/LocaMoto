using System.ComponentModel.DataAnnotations.Schema;

namespace LocaMoto.Models.DTOs
{
    internal class LocacaoItem
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }
        public int ItemServicoId { get; set; }
             
        public decimal Quantidade { get; set; }
    }
}
