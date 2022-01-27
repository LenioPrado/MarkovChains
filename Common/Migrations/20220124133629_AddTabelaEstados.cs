using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Migrations
{
    public partial class AddTabelaEstados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "markov");

            migrationBuilder.CreateTable(
                name: "estados",
                schema: "markov",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoDestino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocorrencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duracao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estados",
                schema: "markov");
        }
    }
}
