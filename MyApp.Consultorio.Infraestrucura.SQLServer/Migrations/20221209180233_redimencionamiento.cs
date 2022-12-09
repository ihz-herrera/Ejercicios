using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Consultorio.Infraestrucura.SQLServer.Migrations
{
    public partial class redimencionamiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCliente",
                schema: "cat",
                table: "Clientes",
                newName: "nombreCliente");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                schema: "cat",
                table: "Clientes",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                schema: "cat",
                table: "Clientes",
                newName: "apellidoCliente");

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                schema: "cat",
                table: "Clientes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "apellidoCliente",
                schema: "cat",
                table: "Clientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombreCliente",
                schema: "cat",
                table: "Clientes",
                newName: "NombreCliente");

            migrationBuilder.RenameColumn(
                name: "direccion",
                schema: "cat",
                table: "Clientes",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "apellidoCliente",
                schema: "cat",
                table: "Clientes",
                newName: "Apellido");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                schema: "cat",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                schema: "cat",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
