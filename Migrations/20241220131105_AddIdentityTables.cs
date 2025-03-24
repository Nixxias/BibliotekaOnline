using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regal_oddzial_IdOddzial",
                table: "regal");

            migrationBuilder.RenameColumn(
                name: "IdOddzial",
                table: "regal",
                newName: "id_oddzial");

            migrationBuilder.RenameIndex(
                name: "IX_regal_IdOddzial",
                table: "regal",
                newName: "IX_regal_id_oddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_regal_oddzial_id_oddzial",
                table: "regal",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regal_oddzial_id_oddzial",
                table: "regal");

            migrationBuilder.RenameColumn(
                name: "id_oddzial",
                table: "regal",
                newName: "IdOddzial");

            migrationBuilder.RenameIndex(
                name: "IX_regal_id_oddzial",
                table: "regal",
                newName: "IX_regal_IdOddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_regal_oddzial_IdOddzial",
                table: "regal",
                column: "IdOddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
