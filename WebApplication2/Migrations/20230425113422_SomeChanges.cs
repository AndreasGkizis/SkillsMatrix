using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    HardSkillId = table.Column<int>(type: "int", nullable: true),
                    SoftSkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_HardSkills_HardSkillId",
                        column: x => x.HardSkillId,
                        principalTable: "HardSkills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tags_SoftSkills_SoftSkillId",
                        column: x => x.SoftSkillId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_HardSkillId",
                table: "Tags",
                column: "HardSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_SoftSkillId",
                table: "Tags",
                column: "SoftSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
