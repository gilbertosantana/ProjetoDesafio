using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    IdCarro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(20)", nullable: true),
                    AnoFabricacao = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cor = table.Column<string>(type: "varchar(20)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.IdCarro);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_Placa",
                table: "Carro",
                column: "Placa",
                unique: true,
                filter: "[Placa] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro");
        }
    }
}
