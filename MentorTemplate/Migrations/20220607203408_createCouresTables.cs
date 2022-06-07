using Microsoft.EntityFrameworkCore.Migrations;

namespace MentorTemplate.Migrations
{
    public partial class createCouresTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coursers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Hearts = table.Column<int>(nullable: false),
                    Humans = table.Column<int>(nullable: false),
                    TrainerName = table.Column<string>(nullable: true),
                    CourseImage = table.Column<string>(nullable: true),
                    TrainerImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coursers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coursers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coursers_PositionId",
                table: "Coursers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coursers");
        }
    }
}
