using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiConcertHub.Migrations
{
    /// <inheritdoc />
    public partial class NewNombreArtistaIntoEventsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombre_artista",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre_artista",
                table: "Events");
        }
    }
}
