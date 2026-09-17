using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTemplate.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSocialMediaToMasterSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isSocialMedia",
                table: "MasterSocialMedia",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isSocialMedia",
                table: "MasterSocialMedia");
        }
    }
}
