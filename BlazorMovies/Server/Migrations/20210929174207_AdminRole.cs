using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class AdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO AspnetRoles (Id, [Name], NormalizedName)
            VALUES ('f051f50e-db8a-4c80-96e6-b0dce871eeda','Admin','Admin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
