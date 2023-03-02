using Microsoft.EntityFrameworkCore.Migrations;

namespace POC.Migrations
{
    public partial class _mi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_POCS_PocId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_PocId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "PocId",
                table: "States");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PocId",
                table: "States",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_PocId",
                table: "States",
                column: "PocId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_POCS_PocId",
                table: "States",
                column: "PocId",
                principalTable: "POCS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
