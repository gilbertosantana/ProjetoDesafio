using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Moto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Carro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Moto_MarcaId",
                table: "Moto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_MarcaId",
                table: "Carro",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Marca_MarcaId",
                table: "Carro",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Moto_Marca_MarcaId",
                table: "Moto",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Marca_MarcaId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Moto_Marca_MarcaId",
                table: "Moto");

            migrationBuilder.DropIndex(
                name: "IX_Moto_MarcaId",
                table: "Moto");

            migrationBuilder.DropIndex(
                name: "IX_Carro_MarcaId",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Moto");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Carro");
        }
    }
}
