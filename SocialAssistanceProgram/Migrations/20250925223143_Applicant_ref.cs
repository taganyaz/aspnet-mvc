using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialAssistanceProgram.Migrations
{
    /// <inheritdoc />
    public partial class Applicant_ref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantSocialProgram");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantSocialProgram_SocialProgramsId",
                table: "ApplicantSocialProgram",
                column: "SocialProgramsId");
        }
    }
}
