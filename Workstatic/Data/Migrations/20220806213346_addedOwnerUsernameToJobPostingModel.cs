using Microsoft.EntityFrameworkCore.Migrations;

namespace Workstatic.Data.Migrations
{
    public partial class addedOwnerUsernameToJobPostingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobLocation",
                table: "JobPostings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerUsername",
                table: "JobPostings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobLocation",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "OwnerUsername",
                table: "JobPostings");
        }
    }
}
