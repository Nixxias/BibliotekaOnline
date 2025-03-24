using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST.Migrations
{
    public partial class UpdateMappings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "pracownicy");

            migrationBuilder.RenameColumn(
                name: "IdKopii",
                table: "wypozyczenia",
                newName: "id_kopii");

            migrationBuilder.RenameColumn(
                name: "IdKlienta",
                table: "wypozyczenia",
                newName: "id_klienta");

            migrationBuilder.RenameColumn(
                name: "DataZwrotu",
                table: "wypozyczenia",
                newName: "data_zwrotu");

            migrationBuilder.RenameColumn(
                name: "DataWypozyczenia",
                table: "wypozyczenia",
                newName: "data_wypozyczenia");

            migrationBuilder.RenameColumn(
                name: "IdWypozyczenia",
                table: "wypozyczenia",
                newName: "id_wypozyczenia");

            migrationBuilder.RenameColumn(
                name: "Siedziba",
                table: "wydawnictwo",
                newName: "siedziba");

            migrationBuilder.RenameColumn(
                name: "NazwaWydawnictwa",
                table: "wydawnictwo",
                newName: "nazwa_wydawnictwa");

            migrationBuilder.RenameColumn(
                name: "DataZalozenia",
                table: "wydawnictwo",
                newName: "data_zalozenia");

            migrationBuilder.RenameColumn(
                name: "IdWydawnictwa",
                table: "wydawnictwo",
                newName: "id_wydawnictwa");

            migrationBuilder.RenameColumn(
                name: "Pietro",
                table: "regal",
                newName: "pietro");

            migrationBuilder.RenameColumn(
                name: "NrRegalu",
                table: "regal",
                newName: "nr_regalu");

            migrationBuilder.RenameColumn(
                name: "IdRegal",
                table: "regal",
                newName: "id_regal");

            migrationBuilder.RenameColumn(
                name: "Stanowisko",
                table: "pracownicy",
                newName: "stanowisko");

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "pracownicy",
                newName: "nazwisko");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "pracownicy",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "pracownicy",
                newName: "imie");

            migrationBuilder.RenameColumn(
                name: "Haslo",
                table: "pracownicy",
                newName: "haslo");

            migrationBuilder.RenameColumn(
                name: "IdPracownicy",
                table: "pracownicy",
                newName: "id_pracownicy");

            migrationBuilder.RenameColumn(
                name: "Miasto",
                table: "oddzial",
                newName: "miasto");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "oddzial",
                newName: "adres");

            migrationBuilder.RenameColumn(
                name: "KodPocztowy",
                table: "oddzial",
                newName: "kod_pocztowy");

            migrationBuilder.RenameColumn(
                name: "IdOddzial",
                table: "oddzial",
                newName: "id_oddzial");

            migrationBuilder.RenameColumn(
                name: "Tytul",
                table: "ksiazka",
                newName: "tytul");

            migrationBuilder.RenameColumn(
                name: "RokWydania",
                table: "ksiazka",
                newName: "rok_wydania");

            migrationBuilder.RenameColumn(
                name: "LiczbaStron",
                table: "ksiazka",
                newName: "liczba_stron");

            migrationBuilder.RenameColumn(
                name: "IdKsiazki",
                table: "ksiazka",
                newName: "id_ksiazki");

            migrationBuilder.RenameColumn(
                name: "IdKsiazki",
                table: "kopie",
                newName: "id_ksiazki");

            migrationBuilder.RenameColumn(
                name: "CzyDostepna",
                table: "kopie",
                newName: "czy_dostepna");

            migrationBuilder.RenameColumn(
                name: "IdKopii",
                table: "kopie",
                newName: "id_kopii");

            migrationBuilder.RenameColumn(
                name: "NazwaGatunku",
                table: "gatunek",
                newName: "nazwa_gatunku");

            migrationBuilder.RenameColumn(
                name: "IdGatunku",
                table: "gatunek",
                newName: "id_gatunku");

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "czytelnicy",
                newName: "nazwisko");

            migrationBuilder.RenameColumn(
                name: "Miasto",
                table: "czytelnicy",
                newName: "miasto");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "czytelnicy",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "czytelnicy",
                newName: "imie");

            migrationBuilder.RenameColumn(
                name: "Haslo",
                table: "czytelnicy",
                newName: "haslo");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "czytelnicy",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "czytelnicy",
                newName: "adres");

            migrationBuilder.RenameColumn(
                name: "NumerPocztowy",
                table: "czytelnicy",
                newName: "numer_pocztowy");

            migrationBuilder.RenameColumn(
                name: "NrTel",
                table: "czytelnicy",
                newName: "nr_tel");

            migrationBuilder.RenameColumn(
                name: "IdKlienta",
                table: "czytelnicy",
                newName: "(id_klienta");

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "autor",
                newName: "nazwisko");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "autor",
                newName: "imie");

            migrationBuilder.RenameColumn(
                name: "DataUrodzenia",
                table: "autor",
                newName: "data_urodzenia");

            migrationBuilder.RenameColumn(
                name: "IdAutora",
                table: "autor",
                newName: "id_autora");

            migrationBuilder.AddColumn<int>(
                name: "CzytelnicyIdKlienta",
                table: "wypozyczenia",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KopieIdKopii",
                table: "wypozyczenia",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOddzial",
                table: "regal",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_autora",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_gatunku",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_regal",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_wydawnictwa",
                table: "ksiazka",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KsiazkaIdKsiazki",
                table: "kopie",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wypozyczenia_CzytelnicyIdKlienta",
                table: "wypozyczenia",
                column: "CzytelnicyIdKlienta");

            migrationBuilder.CreateIndex(
                name: "IX_wypozyczenia_KopieIdKopii",
                table: "wypozyczenia",
                column: "KopieIdKopii");

            migrationBuilder.CreateIndex(
                name: "IX_regal_IdOddzial",
                table: "regal",
                column: "IdOddzial");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_id_autora",
                table: "ksiazka",
                column: "id_autora");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_id_gatunku",
                table: "ksiazka",
                column: "id_gatunku");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_id_regal",
                table: "ksiazka",
                column: "id_regal");

            migrationBuilder.CreateIndex(
                name: "IX_ksiazka_id_wydawnictwa",
                table: "ksiazka",
                column: "id_wydawnictwa");

            migrationBuilder.CreateIndex(
                name: "IX_kopie_KsiazkaIdKsiazki",
                table: "kopie",
                column: "KsiazkaIdKsiazki");

            migrationBuilder.AddForeignKey(
                name: "FK_kopie_ksiazka_KsiazkaIdKsiazki",
                table: "kopie",
                column: "KsiazkaIdKsiazki",
                principalTable: "ksiazka",
                principalColumn: "id_ksiazki");

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_autor_id_autora",
                table: "ksiazka",
                column: "id_autora",
                principalTable: "autor",
                principalColumn: "id_autora",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_gatunek_id_gatunku",
                table: "ksiazka",
                column: "id_gatunku",
                principalTable: "gatunek",
                principalColumn: "id_gatunku",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_regal_id_regal",
                table: "ksiazka",
                column: "id_regal",
                principalTable: "regal",
                principalColumn: "id_regal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ksiazka_wydawnictwo_id_wydawnictwa",
                table: "ksiazka",
                column: "id_wydawnictwa",
                principalTable: "wydawnictwo",
                principalColumn: "id_wydawnictwa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_regal_oddzial_IdOddzial",
                table: "regal",
                column: "IdOddzial",
                principalTable: "oddzial",
                principalColumn: "id_oddzial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wypozyczenia_czytelnicy_CzytelnicyIdKlienta",
                table: "wypozyczenia",
                column: "CzytelnicyIdKlienta",
                principalTable: "czytelnicy",
                principalColumn: "(id_klienta");

            migrationBuilder.AddForeignKey(
                name: "FK_wypozyczenia_kopie_KopieIdKopii",
                table: "wypozyczenia",
                column: "KopieIdKopii",
                principalTable: "kopie",
                principalColumn: "id_kopii");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kopie_ksiazka_KsiazkaIdKsiazki",
                table: "kopie");

            migrationBuilder.DropForeignKey(
                name: "FK_ksiazka_autor_id_autora",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_ksiazka_gatunek_id_gatunku",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_ksiazka_regal_id_regal",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_ksiazka_wydawnictwo_id_wydawnictwa",
                table: "ksiazka");

            migrationBuilder.DropForeignKey(
                name: "FK_regal_oddzial_IdOddzial",
                table: "regal");

            migrationBuilder.DropForeignKey(
                name: "FK_wypozyczenia_czytelnicy_CzytelnicyIdKlienta",
                table: "wypozyczenia");

            migrationBuilder.DropForeignKey(
                name: "FK_wypozyczenia_kopie_KopieIdKopii",
                table: "wypozyczenia");

            migrationBuilder.DropIndex(
                name: "IX_wypozyczenia_CzytelnicyIdKlienta",
                table: "wypozyczenia");

            migrationBuilder.DropIndex(
                name: "IX_wypozyczenia_KopieIdKopii",
                table: "wypozyczenia");

            migrationBuilder.DropIndex(
                name: "IX_regal_IdOddzial",
                table: "regal");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_id_autora",
                table: "ksiazka");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_id_gatunku",
                table: "ksiazka");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_id_regal",
                table: "ksiazka");

            migrationBuilder.DropIndex(
                name: "IX_ksiazka_id_wydawnictwa",
                table: "ksiazka");

            migrationBuilder.DropIndex(
                name: "IX_kopie_KsiazkaIdKsiazki",
                table: "kopie");

            migrationBuilder.DropColumn(
                name: "CzytelnicyIdKlienta",
                table: "wypozyczenia");

            migrationBuilder.DropColumn(
                name: "KopieIdKopii",
                table: "wypozyczenia");

            migrationBuilder.DropColumn(
                name: "IdOddzial",
                table: "regal");

            migrationBuilder.DropColumn(
                name: "id_autora",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "id_gatunku",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "id_regal",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "id_wydawnictwa",
                table: "ksiazka");

            migrationBuilder.DropColumn(
                name: "KsiazkaIdKsiazki",
                table: "kopie");

            migrationBuilder.RenameColumn(
                name: "id_kopii",
                table: "wypozyczenia",
                newName: "IdKopii");

            migrationBuilder.RenameColumn(
                name: "id_klienta",
                table: "wypozyczenia",
                newName: "IdKlienta");

            migrationBuilder.RenameColumn(
                name: "data_zwrotu",
                table: "wypozyczenia",
                newName: "DataZwrotu");

            migrationBuilder.RenameColumn(
                name: "data_wypozyczenia",
                table: "wypozyczenia",
                newName: "DataWypozyczenia");

            migrationBuilder.RenameColumn(
                name: "id_wypozyczenia",
                table: "wypozyczenia",
                newName: "IdWypozyczenia");

            migrationBuilder.RenameColumn(
                name: "siedziba",
                table: "wydawnictwo",
                newName: "Siedziba");

            migrationBuilder.RenameColumn(
                name: "nazwa_wydawnictwa",
                table: "wydawnictwo",
                newName: "NazwaWydawnictwa");

            migrationBuilder.RenameColumn(
                name: "data_zalozenia",
                table: "wydawnictwo",
                newName: "DataZalozenia");

            migrationBuilder.RenameColumn(
                name: "id_wydawnictwa",
                table: "wydawnictwo",
                newName: "IdWydawnictwa");

            migrationBuilder.RenameColumn(
                name: "pietro",
                table: "regal",
                newName: "Pietro");

            migrationBuilder.RenameColumn(
                name: "nr_regalu",
                table: "regal",
                newName: "NrRegalu");

            migrationBuilder.RenameColumn(
                name: "id_regal",
                table: "regal",
                newName: "IdRegal");

            migrationBuilder.RenameColumn(
                name: "stanowisko",
                table: "pracownicy",
                newName: "Stanowisko");

            migrationBuilder.RenameColumn(
                name: "nazwisko",
                table: "pracownicy",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "pracownicy",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "imie",
                table: "pracownicy",
                newName: "Imie");

            migrationBuilder.RenameColumn(
                name: "haslo",
                table: "pracownicy",
                newName: "Haslo");

            migrationBuilder.RenameColumn(
                name: "id_pracownicy",
                table: "pracownicy",
                newName: "IdPracownicy");

            migrationBuilder.RenameColumn(
                name: "miasto",
                table: "oddzial",
                newName: "Miasto");

            migrationBuilder.RenameColumn(
                name: "adres",
                table: "oddzial",
                newName: "Adres");

            migrationBuilder.RenameColumn(
                name: "kod_pocztowy",
                table: "oddzial",
                newName: "KodPocztowy");

            migrationBuilder.RenameColumn(
                name: "id_oddzial",
                table: "oddzial",
                newName: "IdOddzial");

            migrationBuilder.RenameColumn(
                name: "tytul",
                table: "ksiazka",
                newName: "Tytul");

            migrationBuilder.RenameColumn(
                name: "rok_wydania",
                table: "ksiazka",
                newName: "RokWydania");

            migrationBuilder.RenameColumn(
                name: "liczba_stron",
                table: "ksiazka",
                newName: "LiczbaStron");

            migrationBuilder.RenameColumn(
                name: "id_ksiazki",
                table: "ksiazka",
                newName: "IdKsiazki");

            migrationBuilder.RenameColumn(
                name: "id_ksiazki",
                table: "kopie",
                newName: "IdKsiazki");

            migrationBuilder.RenameColumn(
                name: "czy_dostepna",
                table: "kopie",
                newName: "CzyDostepna");

            migrationBuilder.RenameColumn(
                name: "id_kopii",
                table: "kopie",
                newName: "IdKopii");

            migrationBuilder.RenameColumn(
                name: "nazwa_gatunku",
                table: "gatunek",
                newName: "NazwaGatunku");

            migrationBuilder.RenameColumn(
                name: "id_gatunku",
                table: "gatunek",
                newName: "IdGatunku");

            migrationBuilder.RenameColumn(
                name: "nazwisko",
                table: "czytelnicy",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "miasto",
                table: "czytelnicy",
                newName: "Miasto");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "czytelnicy",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "imie",
                table: "czytelnicy",
                newName: "Imie");

            migrationBuilder.RenameColumn(
                name: "haslo",
                table: "czytelnicy",
                newName: "Haslo");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "czytelnicy",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "adres",
                table: "czytelnicy",
                newName: "Adres");

            migrationBuilder.RenameColumn(
                name: "numer_pocztowy",
                table: "czytelnicy",
                newName: "NumerPocztowy");

            migrationBuilder.RenameColumn(
                name: "nr_tel",
                table: "czytelnicy",
                newName: "NrTel");

            migrationBuilder.RenameColumn(
                name: "(id_klienta",
                table: "czytelnicy",
                newName: "IdKlienta");

            migrationBuilder.RenameColumn(
                name: "nazwisko",
                table: "autor",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "imie",
                table: "autor",
                newName: "Imie");

            migrationBuilder.RenameColumn(
                name: "data_urodzenia",
                table: "autor",
                newName: "DataUrodzenia");

            migrationBuilder.RenameColumn(
                name: "id_autora",
                table: "autor",
                newName: "IdAutora");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "pracownicy",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
