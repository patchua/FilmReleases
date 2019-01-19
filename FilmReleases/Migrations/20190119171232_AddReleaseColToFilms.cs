using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmReleases.Migrations
{
    public partial class AddReleaseColToFilms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Release",
                table: "Films",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Release",
                table: "Films");
        }
    }
}
