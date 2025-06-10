using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class FixCourseExamRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_Id",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "587e7e02-610d-4418-8a17-94a2a5ed34a9", "AQAAAAIAAYagAAAAEHqGq253K908mtBRJy0lfSRLAPkHreuWVx8AJd1B2t4ICzMBHmAY7LxTlpTaUPJE9w==", "0554e6f8-e141-4afd-8edc-d631a8eec25d" });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CourseId",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2422b09-308f-40df-9409-a84bed1b6a39", "AQAAAAIAAYagAAAAEPab1Q32SSc3Sy33gnAHxaayghlbFLFehcG7iVmB+qsJQrvLM5Uru1td9r7AfbjeNA==", "1a7ec853-5efc-43cc-903c-6d3aa479d4b5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_Id",
                table: "Exams",
                column: "Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
