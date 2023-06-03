using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaMoto.Api.Migrations
{
    /// <inheritdoc />
    public partial class Modelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Habilitacao = table.Column<int>(type: "int", nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemServicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemServicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Renavam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quilometragem = table.Column<int>(type: "int", nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    MotoId = table.Column<int>(type: "int", nullable: false),
                    DataRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horadevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorLocacao = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    QuilometragemInicial = table.Column<int>(type: "int", nullable: false),
                    QuilometragemFinal = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ValorServico = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ValorItem = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ValorItemTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Valortotallocacao = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacaos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacaos_Motos_MotoId",
                        column: x => x.MotoId,
                        principalTable: "Motos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocacaoId = table.Column<int>(type: "int", nullable: false),
                    ItemServicoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacaoItens_ItemServicos_ItemServicoId",
                        column: x => x.ItemServicoId,
                        principalTable: "ItemServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocacaoItens_Locacaos_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocacaoId = table.Column<int>(type: "int", nullable: false),
                    NumeroCartao = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    NomeTitular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    BandeiraCartao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ValorPagamento = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DadaHoraPagamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Locacaos_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descricao", "Tipo" },
                values: new object[] { 1, "Moto destinada a performace.", "Speed" });

            migrationBuilder.InsertData(
                table: "Motos",
                columns: new[] { "Id", "Ano", "CategoriaId", "Cilindrada", "Cor", "ImagemUrl", "Marca", "Modelo", "Placa", "Quilometragem", "Renavam", "ValorDiaria" },
                values: new object[] { 1, 2022, 1, 1000, "Branca", "/imagens/Speed/yamaha.png", "Yamaha", "X1", "XPT0201", 3500, "1234567", 100m });

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoItens_ItemServicoId",
                table: "LocacaoItens",
                column: "ItemServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoItens_LocacaoId",
                table: "LocacaoItens",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacaos_ClienteId",
                table: "Locacaos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacaos_MotoId",
                table: "Locacaos",
                column: "MotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Motos_CategoriaId",
                table: "Motos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_LocacaoId",
                table: "Pagamentos",
                column: "LocacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacaoItens");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "ItemServicos");

            migrationBuilder.DropTable(
                name: "Locacaos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Motos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
