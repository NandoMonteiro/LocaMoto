namespace LocaMoto.Models.DTOs
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public int CPF { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public string Endereco { get; set; } = string.Empty;
        public int Celular { get; set; }
        public int Habilitacao { get; set; }

        public string Profissao { get; set; } = string.Empty;
    }
}
