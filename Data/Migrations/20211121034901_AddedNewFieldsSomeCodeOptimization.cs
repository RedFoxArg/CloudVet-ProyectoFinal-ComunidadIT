using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudVet.Data.Migrations
{
    public partial class AddedNewFieldsSomeCodeOptimization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Archivado",
                table: "Animales",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archivado",
                table: "Animales");
        }
    }
}
