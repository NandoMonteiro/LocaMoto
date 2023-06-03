using System.ComponentModel.DataAnnotations;

namespace LocaMoto.Api.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public int CPF { get; set; }


        [MaxLength(320)]
        public  string Email { get; set; } = string.Empty;

        [MaxLength(300)]
        public string Nome { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Endereco { get; set; } = string.Empty;
        public int Celular { get; set; }
        public int Habilitacao { get; set; }

        [MaxLength(100)]
        public string Profissao { get; set; } = string.Empty;
    }
}
