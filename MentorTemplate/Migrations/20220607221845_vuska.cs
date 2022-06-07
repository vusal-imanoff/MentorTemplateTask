using Microsoft.EntityFrameworkCore.Migrations;

namespace MentorTemplate.Migrations
{
    public partial class vuska : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Features_FeaturesId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingsId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinPricingFeatures",
                table: "JoinPricingFeatures");

            migrationBuilder.DropIndex(
                name: "IX_JoinPricingFeatures_PricingsId",
                table: "JoinPricingFeatures");

            migrationBuilder.RenameTable(
                name: "Pricings",
                newName: "Pricingss");

            migrationBuilder.RenameTable(
                name: "JoinPricingFeatures",
                newName: "Join");

            migrationBuilder.RenameIndex(
                name: "IX_JoinPricingFeatures_FeaturesId",
                table: "Join",
                newName: "IX_Join_FeaturesId");

            migrationBuilder.AddColumn<int>(
                name: "PricingssId",
                table: "Join",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricingss",
                table: "Pricingss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Join",
                table: "Join",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PricingssId",
                table: "Join",
                column: "PricingssId");

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Features_FeaturesId",
                table: "Join",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Pricingss_PricingssId",
                table: "Join",
                column: "PricingssId",
                principalTable: "Pricingss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Join_Features_FeaturesId",
                table: "Join");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Pricingss_PricingssId",
                table: "Join");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricingss",
                table: "Pricingss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Join",
                table: "Join");

            migrationBuilder.DropIndex(
                name: "IX_Join_PricingssId",
                table: "Join");

            migrationBuilder.DropColumn(
                name: "PricingssId",
                table: "Join");

            migrationBuilder.RenameTable(
                name: "Pricingss",
                newName: "Pricings");

            migrationBuilder.RenameTable(
                name: "Join",
                newName: "JoinPricingFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_Join_FeaturesId",
                table: "JoinPricingFeatures",
                newName: "IX_JoinPricingFeatures_FeaturesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinPricingFeatures",
                table: "JoinPricingFeatures",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingsId",
                table: "JoinPricingFeatures",
                column: "PricingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Features_FeaturesId",
                table: "JoinPricingFeatures",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Pricings_PricingsId",
                table: "JoinPricingFeatures",
                column: "PricingsId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
