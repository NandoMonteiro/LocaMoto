using LocaMoto.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocaMoto.Api.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<ItemServico>? ItemServicos { get; set; }
    public DbSet<Locacao>? Locacaos { get; set; }
    public DbSet<Pagamento>? Pagamentos { get; set; }
    public DbSet<LocacaoItem>? LocacaoItens { get; set; }
    public DbSet<Moto>? Motos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id= 1,
            Tipo = "Speed",
            Descricao = "Moto destinada a performace."
        });
        modelBuilder.Entity<Moto>().HasData(new Moto
        {
            Id= 1,
            Placa = "XPT0201",
            Modelo = "X1",
            Marca = "Yamaha",
            Cilindrada = 1000,
            Cor = "Branca",
            Ano = 2022,
            Renavam = "1234567",
            ValorDiaria = 100,
            Quilometragem = 3500,
            ImagemUrl = "/imagens/Speed/yamaha.png",
            CategoriaId = 1
        });




    }

}
