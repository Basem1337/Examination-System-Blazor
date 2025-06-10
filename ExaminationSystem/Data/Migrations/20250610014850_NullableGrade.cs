using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class NullableGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "StudentCourses",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d7a304c-2892-4387-819f-c6370319d792", "AQAAAAIAAYagAAAAEBbPTdOBwQfluXs5/jrFLBNd9eEbE5WV4o70wHQIhnfyl/Bm714Ig9zPtR6zJRsZtg==", "31a88a9b-190c-4510-8a20-8ee8a7c41903" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "StudentCourses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "587e7e02-610d-4418-8a17-94a2a5ed34a9", "AQAAAAIAAYagAAAAEHqGq253K908mtBRJy0lfSRLAPkHreuWVx8AJd1B2t4ICzMBHmAY7LxTlpTaUPJE9w==", "0554e6f8-e141-4afd-8edc-d631a8eec25d" });
        }
    }
}
