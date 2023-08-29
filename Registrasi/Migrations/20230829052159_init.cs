using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrasi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kombinasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kombinasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agen",
                columns: table => new
                {
                    AgenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(nullable: false),
                    RegStatus = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Addrres = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    IdCard = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    KombinasiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agen", x => x.AgenId);
                    table.ForeignKey(
                        name: "FK_Agen_Kombinasi_KombinasiId",
                        column: x => x.KombinasiId,
                        principalTable: "Kombinasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachmentt",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenId = table.Column<int>(nullable: true),
                    AttachmentType = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    KombinasiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachmentt", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachmentt_Agen_AgenId",
                        column: x => x.AgenId,
                        principalTable: "Agen",
                        principalColumn: "AgenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachmentt_Kombinasi_KombinasiId",
                        column: x => x.KombinasiId,
                        principalTable: "Kombinasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenId = table.Column<int>(nullable: true),
                    Starta = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    GPA = table.Column<string>(nullable: true),
                    StarDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    KombinasiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Education_Agen_AgenId",
                        column: x => x.AgenId,
                        principalTable: "Agen",
                        principalColumn: "AgenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Education_Kombinasi_KombinasiId",
                        column: x => x.KombinasiId,
                        principalTable: "Kombinasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    WorkExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenId = table.Column<int>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Field = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    JobDesc = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    KombinasiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.WorkExperienceId);
                    table.ForeignKey(
                        name: "FK_WorkExperience_Agen_AgenId",
                        column: x => x.AgenId,
                        principalTable: "Agen",
                        principalColumn: "AgenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkExperience_Kombinasi_KombinasiId",
                        column: x => x.KombinasiId,
                        principalTable: "Kombinasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agen_KombinasiId",
                table: "Agen",
                column: "KombinasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachmentt_AgenId",
                table: "Attachmentt",
                column: "AgenId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachmentt_KombinasiId",
                table: "Attachmentt",
                column: "KombinasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_AgenId",
                table: "Education",
                column: "AgenId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_KombinasiId",
                table: "Education",
                column: "KombinasiId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_AgenId",
                table: "WorkExperience",
                column: "AgenId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_KombinasiId",
                table: "WorkExperience",
                column: "KombinasiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachmentt");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.DropTable(
                name: "Agen");

            migrationBuilder.DropTable(
                name: "Kombinasi");
        }
    }
}
