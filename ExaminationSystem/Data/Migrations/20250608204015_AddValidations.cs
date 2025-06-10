using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ExamId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ee61c07-cf3b-4f36-bd3b-3c75b1dddb96", "AQAAAAIAAYagAAAAEJ6YZv/K6o2SeQ4tHndpHxr02JklLBBxnaxTm8bRas6C4rj11Yeos0zgF+E6WpcQpA==", "dbc1b24f-a04b-4fba-b878-7498218eb993" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ExamId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc7d9c87-6088-460e-97a6-0359007ffdfa", "AQAAAAIAAYagAAAAEE62WJQq6G2UlG5R0ykVPAYHAr3EqAbjKA2KHfZly/qXsM3SrhxPc2ixrTfNB2cWwQ==", "631a9ac2-fcf2-4ca6-9d1c-94acc46305ff" });
        }
    }
}
