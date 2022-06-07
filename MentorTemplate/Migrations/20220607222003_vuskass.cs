using Microsoft.EntityFrameworkCore.Migrations;

namespace MentorTemplate.Migrations
{
    public partial class vuskass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingssId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropIndex(
                name: "IX_JoinPricingFeatures_PricingssId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropColumn(
                name: "PricingssId",
                table: "JoinPricingFeatures");

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingsId",
                table: "JoinPricingFeatures",
                column: "PricingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingsId",
                table: "JoinPricingFeatures",
                column: "PricingsId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingsId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropIndex(
                name: "IX_JoinPricingFeatures_PricingsId",
                table: "JoinPricingFeatures");

            migrationBuilder.AddColumn<int>(
                name: "PricingssId",
                table: "JoinPricingFeatures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingssId",
                table: "JoinPricingFeatures",
                column: "PricingssId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingssId",
                table: "JoinPricingFeatures",
                column: "PricingssId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
