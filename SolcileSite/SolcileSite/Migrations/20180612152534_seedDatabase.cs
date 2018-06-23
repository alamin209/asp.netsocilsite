using Microsoft.EntityFrameworkCore.Migrations;

namespace SolcileSite.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('alamin')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('aklima')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('jahangir')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('antor')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('aeysha')");


            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('JOBA',(SELECT Id FROM Makes WHERE Name='alamin'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('AEYSHA',(SELECT Id FROM Makes WHERE Name='jahangir'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('KONO',(SELECT Id FROM Makes WHERE Name='antor'))");
            migrationBuilder.Sql("INSERT INTO Models  (Name,MakeId) VALUES('KAJ',(SELECT Id FROM Makes WHERE Name='aeysha'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
