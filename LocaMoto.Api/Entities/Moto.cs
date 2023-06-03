using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class Moto
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Placa { get; set; } = string.Empty;

        [MaxLength(300)]
        public string Modelo { get; set; } = string.Empty;

        [MaxLength(300)]
        public string Marca { get; set; } = string.Empty;

        public int Cilindrada { get; set; }

        [MaxLength(200)]
        public string Cor { get; set; } = string.Empty;
        public int Ano { get; set; }

        [MaxLength(20)]
        public string Renavam { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorDiaria { get; set; }

        public int Quilometragem { get; set; }


        [MaxLength(500)]
        public string ImagemUrl { get; set; } = string.Empty;

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }


    }
}
