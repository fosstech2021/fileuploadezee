using Microsoft.EntityFrameworkCore.Migrations;

namespace BasePackageModule1.Migrations
{
    public partial class jb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerFullName = table.Column<string>(nullable: false),
                    OwnerMobile = table.Column<string>(maxLength: 10, nullable: false),
                    OwnerPancard = table.Column<string>(nullable: false),
                    AadharCard = table.Column<string>(nullable: false),
                    AgreementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_Agreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "Agreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_AgreementId",
                table: "Owners",
                column: "AgreementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.AddColumn<string>(
                name: "AadharCard",
                table: "Agreements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerFullName",
                table: "Agreements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerMobile",
                table: "Agreements",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerPancard",
                table: "Agreements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
