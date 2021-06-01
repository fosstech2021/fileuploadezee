using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasePackageModule1.Migrations
{
    public partial class AddedAgreementdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgreementDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyDetails = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    PropertyType = table.Column<string>(nullable: false),
                    PropertyUse = table.Column<string>(nullable: false),
                    OwnerFirstName = table.Column<string>(nullable: false),
                    OwnerMiddleName = table.Column<string>(nullable: true),
                    OwnerLastName = table.Column<string>(nullable: true),
                    OwnerSalutation = table.Column<string>(nullable: false),
                    OwnerAge = table.Column<string>(nullable: false),
                    OwnerPan = table.Column<string>(nullable: false),
                    OwnerAddress = table.Column<string>(nullable: false),
                    TenantFirstName = table.Column<string>(nullable: false),
                    TenantMiddleName = table.Column<string>(nullable: true),
                    TenantLastName = table.Column<string>(nullable: true),
                    TenantSalutation = table.Column<string>(nullable: false),
                    TenantAge = table.Column<string>(nullable: false),
                    TenantPan = table.Column<string>(nullable: false),
                    TenantAddress = table.Column<string>(nullable: false),
                    AverageRent = table.Column<string>(nullable: false),
                    SecurityDeposit = table.Column<string>(nullable: false),
                    Noofmonths = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    OwnerAdharCardFile = table.Column<string>(nullable: false),
                    OwnerPanCardFile = table.Column<string>(nullable: false),
                    TenantAdharCardFile = table.Column<string>(nullable: false),
                    TenantPanCardFile = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgreementDetails_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementDetails_ApplicationUserId",
                table: "AgreementDetails",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementDetails");
        }
    }
}
