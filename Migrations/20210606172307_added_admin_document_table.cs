using Microsoft.EntityFrameworkCore.Migrations;

namespace BasePackageModule1.Migrations
{
    public partial class added_admin_document_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReceivedAgreement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentUrl = table.Column<string>(nullable: false),
                    AgreementDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivedAgreement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivedAgreement_AgreementDetails_AgreementDetailsId",
                        column: x => x.AgreementDetailsId,
                        principalTable: "AgreementDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedAgreement_AgreementDetailsId",
                table: "ReceivedAgreement",
                column: "AgreementDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceivedAgreement");
        }
    }
}
