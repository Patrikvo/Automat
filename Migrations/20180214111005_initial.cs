using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Automat.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dossierPersoon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DossierPersoonId = table.Column<int>(nullable: true),
                    IsHoofdklant = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    dossierId = table.Column<int>(nullable: false),
                    persoonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dossierPersoon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dossierPersoon_dossierPersoon_DossierPersoonId",
                        column: x => x.DossierPersoonId,
                        principalTable: "dossierPersoon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dossiers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DossierId = table.Column<int>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    dossierLinkToFiles = table.Column<string>(nullable: true),
                    dossierNummer = table.Column<string>(nullable: false),
                    dossierStandvanzaken = table.Column<string>(nullable: true),
                    dossierTitel = table.Column<string>(nullable: true),
                    isGearchiveerd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dossiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dossiers_dossiers_DossierId",
                        column: x => x.DossierId,
                        principalTable: "dossiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersoonId = table.Column<int>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    departement = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    naam = table.Column<string>(nullable: false),
                    organisatie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personen_personen_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "personen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dossierPersoon_DossierPersoonId",
                table: "dossierPersoon",
                column: "DossierPersoonId");

            migrationBuilder.CreateIndex(
                name: "IX_dossiers_DossierId",
                table: "dossiers",
                column: "DossierId");

            migrationBuilder.CreateIndex(
                name: "IX_personen_PersoonId",
                table: "personen",
                column: "PersoonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dossierPersoon");

            migrationBuilder.DropTable(
                name: "dossiers");

            migrationBuilder.DropTable(
                name: "personen");
        }
    }
}
