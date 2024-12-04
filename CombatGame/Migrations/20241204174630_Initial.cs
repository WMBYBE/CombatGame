using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombatGame.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalWins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalWins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    teamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Teams_teamId",
                        column: x => x.teamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    MoveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<double>(type: "float", nullable: false),
                    speed = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.MoveId);
                    table.ForeignKey(
                        name: "FK_Moves_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId");
                });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "MoveId", "CharacterId", "Description", "Name", "Power", "Type", "speed" },
                values: new object[] { 1, null, "Basic attack", "Attack", 1.0, "Physical", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "Password", "TotalWins", "UserName" },
                values: new object[] { 1, "321", 0, "NYnumb1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "Password", "TotalWins", "UserName" },
                values: new object[] { 2, "123", 10, "GERno1" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Name", "TotalWins", "UserId" },
                values: new object[] { 1, "Boston Beaters", 0, 1 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Name", "TotalWins", "UserId" },
                values: new object[] { 2, "Das Boyyen", 10, 2 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Agility", "Defense", "HP", "Intelligence", "Name", "Strength", "teamId" },
                values: new object[,]
                {
                    { 1, 10, 10, 10, 7, "Dave", 20, 1 },
                    { 2, 8, 10, 5, 25, "Tony", 5, 1 },
                    { 3, 25, 10, 5, 5, "Peter Griffin", 5, 1 },
                    { 4, 10, 10, 10, 20, "Kyle", 7, 2 },
                    { 5, 8, 10, 5, 5, "Terry", 25, 2 },
                    { 6, 25, 10, 5, 5, "Matt", 8, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_teamId",
                table: "Characters",
                column: "teamId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_CharacterId",
                table: "Moves",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserId",
                table: "Teams",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
