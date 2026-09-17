using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTemplate.Migrations
{
    /// <inheritdoc />
    public partial class addAuditUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterWhatIDo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterWhatIDo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterWhatIDo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterTitles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterTitles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterTitles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterTestimonials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterTestimonials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterTestimonials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterSocialMedia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterSocialMedia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterSocialMedia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterPositions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterPositions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterPositions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterFunFacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterFunFacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterFunFacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterEducationAndExperience",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterEducationAndExperience",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterEducationAndExperience",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterCilents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterCilents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterCilents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "MasterAbouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteUser",
                table: "MasterAbouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditUser",
                table: "MasterAbouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterWhatIDo");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterWhatIDo");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterWhatIDo");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterTitles");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterTitles");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterTitles");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterTestimonials");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterTestimonials");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterTestimonials");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterSocialMedia");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterSocialMedia");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterSocialMedia");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterSkills");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterSkills");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterSkills");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterPositions");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterPositions");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterPositions");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterFunFacts");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterFunFacts");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterFunFacts");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterEducationAndExperience");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterEducationAndExperience");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterEducationAndExperience");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterCilents");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterCilents");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterCilents");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterCertificates");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterCertificates");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterCertificates");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "MasterAbouts");

            migrationBuilder.DropColumn(
                name: "DeleteUser",
                table: "MasterAbouts");

            migrationBuilder.DropColumn(
                name: "EditUser",
                table: "MasterAbouts");
        }
    }
}
