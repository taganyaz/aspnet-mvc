using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialAssistanceProgram.Migrations
{
    /// <inheritdoc />
    public partial class ApplicantSocialPrograms_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_SocialPrograms_SocialProgramId",
                table: "Applicant");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_SocialProgramId",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "SocialProgramId",
                table: "Applicant");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SocialPrograms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SocialPrograms",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicantSocialProgram",
                columns: table => new
                {
                    ApplicantsId = table.Column<int>(type: "int", nullable: false),
                    SocialProgramsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantSocialProgram", x => new { x.ApplicantsId, x.SocialProgramsId });
                    table.ForeignKey(
                        name: "FK_ApplicantSocialProgram_Applicant_ApplicantsId",
                        column: x => x.ApplicantsId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicantSocialProgram_SocialPrograms_SocialProgramsId",
                        column: x => x.SocialProgramsId,
                        principalTable: "SocialPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantSocialPrograms",
                columns: table => new
                {
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    SocialProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantSocialPrograms", x => new { x.ApplicantId, x.SocialProgramId });
                    table.ForeignKey(
                        name: "FK_ApplicantSocialPrograms_Applicant_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicantSocialPrograms_SocialPrograms_SocialProgramId",
                        column: x => x.SocialProgramId,
                        principalTable: "SocialPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantSocialProgram_SocialProgramsId",
                table: "ApplicantSocialProgram",
                column: "SocialProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantSocialPrograms_SocialProgramId",
                table: "ApplicantSocialPrograms",
                column: "SocialProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantSocialProgram");

            migrationBuilder.DropTable(
                name: "ApplicantSocialPrograms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SocialPrograms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SocialPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "SocialProgramId",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_SocialProgramId",
                table: "Applicant",
                column: "SocialProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_SocialPrograms_SocialProgramId",
                table: "Applicant",
                column: "SocialProgramId",
                principalTable: "SocialPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
