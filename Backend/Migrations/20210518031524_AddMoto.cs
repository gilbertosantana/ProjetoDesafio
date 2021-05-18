using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddMoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    IdMoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(20)", nullable: true),
                    AnoFabricacao = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cor = table.Column<string>(type: "varchar(20)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.IdMoto);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moto_Placa",
                table: "Moto",
                column: "Placa",
                unique: true,
                filter: "[Placa] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moto");
        }
    }
}
