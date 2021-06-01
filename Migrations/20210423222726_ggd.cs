using Microsoft.EntityFrameworkCore.Migrations;

namespace BasePackageModule1.Migrations
{
    public partial class ggd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AadharCard",
                table: "Agreements",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerFullName",
                table: "Agreements",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerMobile",
                table: "Agreements",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerPancard",
                table: "Agreements",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadharCard",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "OwnerFullName",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "OwnerMobile",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "OwnerPancard",
                table: "Agreements");
        }
    }
}
