using Microsoft.EntityFrameworkCore.Migrations;

namespace SolcileSite.Migrations
{
    public partial class Seedfeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Feature (Name) VALUES ('Feature1')");
            migrationBuilder.Sql("INSERT INTO Feature (Name) VALUES ('Feature2')");
            migrationBuilder.Sql("INSERT INTO Feature (Name) VALUES ('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
