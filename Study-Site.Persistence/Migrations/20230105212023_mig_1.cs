using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StudySite.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClockTower",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<float>(type: "real", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockTower", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ClockTowerId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Buildings = table.Column<List<string>>(type: "text[]", nullable: false),
                    Workers = table.Column<int>(type: "integer", nullable: false),
                    WoodResource = table.Column<int>(type: "integer", nullable: false),
                    StoneResource = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_ClockTower_ClockTowerId",
                        column: x => x.ClockTowerId,
                        principalTable: "ClockTower",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Towns_ClockTowerId",
                table: "Towns",
                column: "ClockTowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "ClockTower");
        }
    }
}
