namespace LocaMoto.Models.DTOs
{
    public class MotoDto
    {
        public int Id { get; set; }

        public string Placa { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int Cilindrada { get; set; }

        public string Cor { get; set; }
        public int Ano { get; set; }

        public string Renavam { get; set; }

        public decimal ValorDiaria { get; set; }

        public int Quilometragem { get; set; }

        public string ImagemUrl { get; set; }

        public int CategoriaId { get; set; }

    }
}
