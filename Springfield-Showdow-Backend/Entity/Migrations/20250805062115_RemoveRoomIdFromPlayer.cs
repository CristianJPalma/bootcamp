using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRoomIdFromPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Players_PlayerId",
                table: "Rounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_Players_PlayerId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_Shifts_PlayerId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_Rounds_PlayerId",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "IsCreator",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Shifts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Rounds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCreator",
                table: "Players",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_PlayerId",
                table: "Shifts",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_PlayerId",
                table: "Rounds",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Players_PlayerId",
                table: "Rounds",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_Players_PlayerId",
                table: "Shifts",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
