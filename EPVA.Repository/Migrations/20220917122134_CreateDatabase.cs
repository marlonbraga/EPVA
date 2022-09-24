using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPVA.Repository.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aula_Modulo_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classe_Modulo_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classe_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Backdrop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AulaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Aula_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aula",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Material_Modulo_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Aula_ModuloId",
                table: "Aula",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Classe_ModuloId",
                table: "Classe",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Classe_ProfessorId",
                table: "Classe",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_AulaId",
                table: "Material",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_ModuloId",
                table: "Material",
                column: "ModuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoClasse");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Modulo");
        }
    }
}
