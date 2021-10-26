using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAutomovel.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automeveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, precision: 12, scale: 2, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automeveis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Automeveis",
                columns: new[] { "Id", "Descricao", "Modelo", "Placa", "Preco" },
                values: new object[] { 1, "é um carro quadrado com 3 rodas", "Ford triciclo", "asn 1111", 500.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automeveis");
        }
    }
}
