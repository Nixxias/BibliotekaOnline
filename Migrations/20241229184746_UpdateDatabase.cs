using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST.Migrations
{
    public partial class UpdateDatabase : Migration
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
                name: "id_oddzial",
                table: "wypozyczenia",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_oddzial",
                table: "pracownicy",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_oddzial",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_oddzial",
                table: "czytelnicy",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_wypozyczenia_id_oddzial",
                table: "wypozyczenia",
                column: "id_oddzial");

            migrationBuilder.CreateIndex(
                name: "IX_pracownicy_id_oddzial",
                table: "pracownicy",
                column: "id_oddzial");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_id_oddzial",
                table: "ksiazka",
                column: "id_oddzial");

            migrationBuilder.CreateIndex(
                name: "IX_czytelnicy_id_oddzial",
                table: "czytelnicy",
                column: "id_oddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_czytelnicy_oddzial_id_oddzial",
                table: "czytelnicy",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_oddzial_id_oddzial",
                table: "ksiazka",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pracownicy_oddzial_id_oddzial",
                table: "pracownicy",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial");

            migrationBuilder.AddForeignKey(
                name: "FK_regal_oddzial_id_oddzial",
                table: "regal",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wypozyczenia_oddzial_id_oddzial",
                table: "wypozyczenia",
                column: "id_oddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_czytelnicy_oddzial_id_oddzial",
                table: "czytelnicy");

            migrationBuilder.DropForeignKey(
                name: "FK_ksiazka_oddzial_id_oddzial",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_pracownicy_oddzial_id_oddzial",
                table: "pracownicy");

            migrationBuilder.DropForeignKey(
                name: "FK_regal_oddzial_id_oddzial",
                table: "regal");

            migrationBuilder.DropForeignKey(
                name: "FK_wypozyczenia_oddzial_id_oddzial",
                table: "wypozyczenia");

            migrationBuilder.DropIndex(
                name: "IX_wypozyczenia_id_oddzial",
                table: "wypozyczenia");

            migrationBuilder.DropIndex(
                name: "IX_pracownicy_id_oddzial",
                table: "pracownicy");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_id_oddzial",
                table: "ksiazka");

            migrationBuilder.DropIndex(
                name: "IX_czytelnicy_id_oddzial",
                table: "czytelnicy");

            migrationBuilder.DropColumn(
                name: "id_oddzial",
                table: "wypozyczenia");

            migrationBuilder.DropColumn(
                name: "id_oddzial",
                table: "pracownicy");

            migrationBuilder.DropColumn(
                name: "id_oddzial",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "id_oddzial",
                table: "czytelnicy");

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
