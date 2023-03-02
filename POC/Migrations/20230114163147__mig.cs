using Microsoft.EntityFrameworkCore.Migrations;

namespace POC.Migrations
{
    public partial class _mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    factoryLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalGovernments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lga = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovernments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "POCS",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    AdminPhoneNumber = table.Column<string>(nullable: true),
                    SecretCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POCS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PocId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_POCS_PocId",
                        column: x => x.PocId,
                        principalTable: "POCS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_States_PocId",
                table: "States",
                column: "PocId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "LocalGovernments");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "POCS");
        }
    }
}
