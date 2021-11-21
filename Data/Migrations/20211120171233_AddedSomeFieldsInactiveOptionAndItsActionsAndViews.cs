using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudVet.Data.Migrations
{
    public partial class AddedSomeFieldsInactiveOptionAndItsActionsAndViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MesesAños",
                table: "Animales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFalle",
                table: "Animales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Inactivo",
                table: "Animales",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaFalle",
                table: "Animales");

            migrationBuilder.DropColumn(
                name: "Inactivo",
                table: "Animales");

            migrationBuilder.AlterColumn<string>(
                name: "MesesAños",
                table: "Animales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
