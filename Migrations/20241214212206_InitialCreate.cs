using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TEST.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    IdAutora = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Imie = table.Column<string>(type: "text", nullable: false),
                    Nazwisko = table.Column<string>(type: "text", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.IdAutora);
                });

            migrationBuilder.CreateTable(
                name: "czytelnicy",
                columns: table => new
                {
                    IdKlienta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Imie = table.Column<string>(type: "text", nullable: false),
                    Nazwisko = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Haslo = table.Column<string>(type: "text", nullable: false),
                    Miasto = table.Column<string>(type: "text", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    NumerPocztowy = table.Column<string>(type: "text", nullable: false),
                    NrTel = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_czytelnicy", x => x.IdKlienta);
                });

            migrationBuilder.CreateTable(
                name: "gatunek",
                columns: table => new
                {
                    IdGatunku = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NazwaGatunku = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gatunek", x => x.IdGatunku);
                });

            migrationBuilder.CreateTable(
                name: "kopie",
                columns: table => new
                {
                    IdKopii = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdKsiazki = table.Column<int>(type: "integer", nullable: false),
                    CzyDostepna = table.Column<char>(type: "character(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kopie", x => x.IdKopii);
                });

            migrationBuilder.CreateTable(
                name: "ksiazka",
                columns: table => new
                {
                    IdKsiazki = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tytul = table.Column<string>(type: "text", nullable: false),
                    RokWydania = table.Column<int>(type: "integer", nullable: false),
                    LiczbaStron = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ksiazka", x => x.IdKsiazki);
                });

            migrationBuilder.CreateTable(
                name: "oddzial",
                columns: table => new
                {
                    IdOddzial = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    KodPocztowy = table.Column<string>(type: "text", nullable: false),
                    Miasto = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oddzial", x => x.IdOddzial);
                });

            migrationBuilder.CreateTable(
                name: "pracownicy",
                columns: table => new
                {
                    IdPracownicy = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Imie = table.Column<string>(type: "text", nullable: false),
                    Nazwisko = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Haslo = table.Column<string>(type: "text", nullable: false),
                    Stanowisko = table.Column<string>(type: "text", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pracownicy", x => x.IdPracownicy);
                });

            migrationBuilder.CreateTable(
                name: "regal",
                columns: table => new
                {
                    IdRegal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pietro = table.Column<int>(type: "integer", nullable: false),
                    NrRegalu = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regal", x => x.IdRegal);
                });

            migrationBuilder.CreateTable(
                name: "wydawnictwo",
                columns: table => new
                {
                    IdWydawnictwa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NazwaWydawnictwa = table.Column<string>(type: "text", nullable: false),
                    Siedziba = table.Column<string>(type: "text", nullable: false),
                    DataZalozenia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wydawnictwo", x => x.IdWydawnictwa);
                });

            migrationBuilder.CreateTable(
                name: "wypozyczenia",
                columns: table => new
                {
                    IdWypozyczenia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdKlienta = table.Column<int>(type: "integer", nullable: false),
                    IdKopii = table.Column<int>(type: "integer", nullable: false),
                    DataWypozyczenia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataZwrotu = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wypozyczenia", x => x.IdWypozyczenia);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropTable(
                name: "czytelnicy");

            migrationBuilder.DropTable(
                name: "gatunek");

            migrationBuilder.DropTable(
                name: "kopie");

            migrationBuilder.DropTable(
                name: "ksiazka");

            migrationBuilder.DropTable(
                name: "oddzial");

            migrationBuilder.DropTable(
                name: "pracownicy");

            migrationBuilder.DropTable(
                name: "regal");

            migrationBuilder.DropTable(
                name: "wydawnictwo");

            migrationBuilder.DropTable(
                name: "wypozyczenia");
        }
    }
}
