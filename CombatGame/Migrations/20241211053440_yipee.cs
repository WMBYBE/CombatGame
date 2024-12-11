using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombatGame.Migrations
{
    public partial class yipee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "TeamMembers",
                newName: "TeamMemberid");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_CharacterId",
                table: "TeamMembers",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Characters_CharacterId",
                table: "TeamMembers",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Characters_CharacterId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_CharacterId",
                table: "TeamMembers");

            migrationBuilder.RenameColumn(
                name: "TeamMemberid",
                table: "TeamMembers",
                newName: "id");
        }
    }
}
