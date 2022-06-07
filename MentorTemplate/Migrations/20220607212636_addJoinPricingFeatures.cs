using Microsoft.EntityFrameworkCore.Migrations;

namespace MentorTemplate.Migrations
{
    public partial class addJoinPricingFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinPricingFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingsId = table.Column<int>(nullable: false),
                    FeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinPricingFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinPricingFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinPricingFeatures_Pricings_PricingsId",
                        column: x => x.PricingsId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_FeaturesId",
                table: "JoinPricingFeatures",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingsId",
                table: "JoinPricingFeatures",
                column: "PricingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinPricingFeatures");
        }
    }
}
