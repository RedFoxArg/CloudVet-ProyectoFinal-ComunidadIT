using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudVet.Data.Migrations
{
    public partial class AddedMesesAñosDBFieldAndMadeSomeRelatedModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MesesAños",
                table: "Animales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MesesAños",
                table: "Animales");
        }
    }
}
