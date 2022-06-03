using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class Add_FK_ZombieType_Zombie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZombieTypeId",
                table: "zombie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_zombie_ZombieTypeId",
                table: "zombie",
                column: "ZombieTypeId");

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

            migrationBuilder.DropIndex(
                name: "IX_zombie_ZombieTypeId",
                table: "zombie");

            migrationBuilder.DropColumn(
                name: "ZombieTypeId",
                table: "zombie");
        }
    }
}
