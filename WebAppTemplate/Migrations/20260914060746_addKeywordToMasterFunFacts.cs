using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTemplate.Migrations
{
    /// <inheritdoc />
    public partial class addKeywordToMasterFunFacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keyword",
                table: "MasterFunFacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keyword",
                table: "MasterFunFacts");
        }
    }
}
