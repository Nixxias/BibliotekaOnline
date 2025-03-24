using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST.Migrations
{
    public partial class FixForeignKeyMappings : Migration
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

            migrationBuilder.RenameColumn(
                name: "(id_klienta",
                table: "czytelnicy",
                newName: "id_klienta");

            migrationBuilder.AddColumn<int>(
                name: "IdOddzial",
                table: "pracownicy",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OddzialIdOddzial",
                table: "pracownicy",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOddzial",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OddzialIdOddzial",
                table: "ksiazka",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pracownicy_OddzialIdOddzial",
                table: "pracownicy",
                column: "OddzialIdOddzial");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_OddzialIdOddzial",
                table: "ksiazka",
                column: "OddzialIdOddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_oddzial_OddzialIdOddzial",
                table: "ksiazka",
                column: "OddzialIdOddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_pracownicy_oddzial_OddzialIdOddzial",
                table: "pracownicy",
                column: "OddzialIdOddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial");

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
                name: "FK_ksiazka_oddzial_OddzialIdOddzial",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_pracownicy_oddzial_OddzialIdOddzial",
                table: "pracownicy");

            migrationBuilder.DropForeignKey(
                name: "FK_regal_oddzial_id_oddzial",
                table: "regal");

            migrationBuilder.DropIndex(
                name: "IX_pracownicy_OddzialIdOddzial",
                table: "pracownicy");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_OddzialIdOddzial",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "IdOddzial",
                table: "pracownicy");

            migrationBuilder.DropColumn(
                name: "OddzialIdOddzial",
                table: "pracownicy");

            migrationBuilder.DropColumn(
                name: "IdOddzial",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "OddzialIdOddzial",
                table: "ksiazka");

            migrationBuilder.RenameColumn(
                name: "id_oddzial",
                table: "regal",
                newName: "IdOddzial");

            migrationBuilder.RenameIndex(
                name: "IX_regal_id_oddzial",
                table: "regal",
                newName: "IX_regal_IdOddzial");

            migrationBuilder.RenameColumn(
                name: "id_klienta",
                table: "czytelnicy",
                newName: "(id_klienta");

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
