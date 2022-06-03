using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class AddHuntingLogCorr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zombie_ZombieType_ZombieTypeId",
                table: "zombie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZombieType",
                table: "ZombieType");

            migrationBuilder.RenameTable(
                name: "ZombieType",
                newName: "zombieTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zombieTypes",
                table: "zombieTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HuntingLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLog", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_zombie_zombieTypes_ZombieTypeId",
                table: "zombie",
                column: "ZombieTypeId",
                principalTable: "zombieTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zombie_zombieTypes_ZombieTypeId",
                table: "zombie");

            migrationBuilder.DropTable(
                name: "HuntingLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zombieTypes",
                table: "zombieTypes");

            migrationBuilder.RenameTable(
                name: "zombieTypes",
                newName: "ZombieType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZombieType",
                table: "ZombieType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_zombie_ZombieType_ZombieTypeId",
                table: "zombie",
                column: "ZombieTypeId",
                principalTable: "ZombieType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
