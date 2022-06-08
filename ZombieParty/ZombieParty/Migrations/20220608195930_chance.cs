using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class chance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Zombie",
                newName: "ShortDesc");

            migrationBuilder.AddColumn<int>(
                name: "Force",
                table: "Zombie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZombieTypeId",
                table: "Zombie",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "ZombieType",
                columns: new[] { "Id", "TypeName" },
                values: new object[,]
                {
                    { 1, "Contact" },
                    { 2, "Virus" },
                    { 3, "Chimique" },
                    { 4, "Morsure" },
                    { 5, "vampzombie" }
                });

            migrationBuilder.InsertData(
                table: "Zombie",
                columns: new[] { "Id", "Force", "Name", "Point", "ShortDesc", "ZombieTypeId" },
                values: new object[,]
                {
                    { 1, 8, "LeChuck", 5, "Pirate des Caraibes", 1 },
                    { 14, 2, "The Clown", 5, "Le clown malheureux qui court après les enfants", 3 },
                    { 12, 9, "Lady Rose", 6, "", 3 },
                    { 11, 9, "Avogadro", 9, "Attaque avec des éclairs suite à un orage", 3 },
                    { 10, 5, "chien de l'enfer", 7, "chien très rapide, pouvant être enflammé", 3 },
                    { 9, 3, "Singe zombie", 2, "Voleur très rapide", 3 },
                    { 7, 1, "Taxidermy ", 1, "Tête de cerf empaillé, voisin de Lenore", 3 },
                    { 16, 9, "TeamsZombie", 10, "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", 3 },
                    { 4, 9, "Draugr", 2, "Vivant dans sa tombe grandant son trésor", 3 },
                    { 13, 10, "Matbeth", 2, "Jeune étudiante qui cherche son professeur pour se venger", 2 },
                    { 5, 4, "Ragamuffin ", 5, "Ancien vampire transformé en poupée de chiffon, ami de Lenore", 2 },
                    { 3, 4, "Baron Samedi", 8, "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", 2 },
                    { 2, 6, "Lenore", 4, "Cute Little Dead Girl", 2 },
                    { 8, 9, "Kitty", 3, "Chat mort de Lenore", 1 },
                    { 6, 3, "Mr Gosh", 6, "Tête de sac avec yeux en boutons, amoureux de Lenore", 1 },
                    { 15, 5, "Clicker", 4, "Le comptable mécontent qui cherche les failles", 2 },
                    { 17, 7, "Mathilde", 4, "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ZombieTypeId",
                table: "Zombie",
                column: "ZombieTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zombie_ZombieType_ZombieTypeId",
                table: "Zombie",
                column: "ZombieTypeId",
                principalTable: "ZombieType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zombie_ZombieType_ZombieTypeId",
                table: "Zombie");

            migrationBuilder.DropTable(
                name: "HuntingLog");

            migrationBuilder.DropIndex(
                name: "IX_Zombie_ZombieTypeId",
                table: "Zombie");

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Force",
                table: "Zombie");

            migrationBuilder.DropColumn(
                name: "ZombieTypeId",
                table: "Zombie");

            migrationBuilder.RenameColumn(
                name: "ShortDesc",
                table: "Zombie",
                newName: "Type");
        }
    }
}
