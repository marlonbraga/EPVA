using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPVA.Repository.Migrations
{
    public partial class RefactorEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoClasse");

            migrationBuilder.AddColumn<Guid>(
                name: "ClasseId",
                table: "Aluno",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_ClasseId",
                table: "Aluno",
                column: "ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Classe_ClasseId",
                table: "Aluno",
                column: "ClasseId",
                principalTable: "Classe",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Classe_ClasseId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_ClasseId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Aluno");

            migrationBuilder.CreateTable(
                name: "AlunoClasse",
                columns: table => new
                {
                    AlunosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoClasse", x => new { x.AlunosId, x.ClassesId });
                    table.ForeignKey(
                        name: "FK_AlunoClasse_Aluno_AlunosId",
                        column: x => x.AlunosId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoClasse_Classe_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoClasse_ClassesId",
                table: "AlunoClasse",
                column: "ClassesId");
        }
    }
}
