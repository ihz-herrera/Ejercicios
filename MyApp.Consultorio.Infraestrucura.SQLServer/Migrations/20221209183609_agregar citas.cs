using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Consultorio.Infraestrucura.SQLServer.Migrations
{
    public partial class agregarcitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "At");

            migrationBuilder.CreateTable(
                name: "Doctores",
                schema: "cat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDeTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreDoctor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidoDoctor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("codigoDoctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegCitas",
                schema: "At",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegCitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegCitas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "cat",
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegCitas_Doctores_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "cat",
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegCitas_ClienteId",
                schema: "At",
                table: "RegCitas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RegCitas_DoctorId",
                schema: "At",
                table: "RegCitas",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegCitas",
                schema: "At");

            migrationBuilder.DropTable(
                name: "Doctores",
                schema: "cat");
        }
    }
}
