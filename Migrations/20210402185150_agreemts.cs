using Microsoft.EntityFrameworkCore.Migrations;

namespace BasePackageModule1.Migrations
{
    public partial class agreemts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerFullName = table.Column<string>(nullable: true),
                    OwnerMobile = table.Column<string>(nullable: true),
                    OwnerPancard = table.Column<string>(nullable: true),
                    AadharCard = table.Column<string>(nullable: true),
                    tenantFullName = table.Column<string>(nullable: true),
                    tenantMobile = table.Column<string>(nullable: true),
                    tenantPancard = table.Column<string>(nullable: true),
                    tenantAadharCard = table.Column<string>(nullable: true),
                    RentOnPremises = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreements");
        }
    }
}
