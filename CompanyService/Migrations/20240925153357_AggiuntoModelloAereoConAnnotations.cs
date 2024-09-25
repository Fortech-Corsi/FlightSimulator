using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyService.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntoModelloAereoConAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AereiConAnnotations",
                columns: table => new
                {
                    AereoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodiceAereo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colore = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroDiPosti = table.Column<long>(type: "bigint", nullable: false),
                    FlottaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AereiConAnnotations", x => x.AereoId);
                    table.ForeignKey(
                        name: "FK_AereiConAnnotations_Flotte_FlottaId",
                        column: x => x.FlottaId,
                        principalTable: "Flotte",
                        principalColumn: "FlottaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AereiConAnnotations_FlottaId",
                table: "AereiConAnnotations",
                column: "FlottaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AereiConAnnotations");
        }
    }
}
