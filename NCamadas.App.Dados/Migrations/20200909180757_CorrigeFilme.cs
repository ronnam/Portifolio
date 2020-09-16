using Microsoft.EntityFrameworkCore.Migrations;

namespace NCamadas.App.Dados.Migrations
{
    public partial class CorrigeFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classificacao",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Filmes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "Classificacao",
                table: "Filmes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
