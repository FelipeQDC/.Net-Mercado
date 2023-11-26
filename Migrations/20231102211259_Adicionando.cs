using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioApi.Migrations
{
    /// <inheritdoc />
    public partial class Adicionando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Produtos",
                table: "Transacao",
                newName: "status");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Transacao",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Transacao");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Transacao",
                newName: "Produtos");
        }
    }
}
