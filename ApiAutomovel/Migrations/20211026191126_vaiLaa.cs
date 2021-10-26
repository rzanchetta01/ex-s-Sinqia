using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAutomovel.Migrations
{
    public partial class vaiLaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automeveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NumRodas = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    NumPortas = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    tipoCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automeveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCarro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoVeiculo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCarro", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Automeveis",
                columns: new[] { "Id", "Cor", "Descricao", "Modelo", "NumPortas", "NumRodas", "Placa", "Preco", "tipoCarro" },
                values: new object[] { 1, "Branco", "Carro semi novo", "Ford Focus", 4, 4, "asp-9823", 30000m, 1 });

            migrationBuilder.InsertData(
                table: "TipoCarro",
                columns: new[] { "Id", "TipoVeiculo" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Picape" },
                    { 3, "SUV" },
                    { 4, "Esportivo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automeveis");

            migrationBuilder.DropTable(
                name: "TipoCarro");
        }
    }
}
