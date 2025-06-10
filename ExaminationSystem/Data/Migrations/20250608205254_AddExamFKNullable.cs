using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddExamFKNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2422b09-308f-40df-9409-a84bed1b6a39", "AQAAAAIAAYagAAAAEPab1Q32SSc3Sy33gnAHxaayghlbFLFehcG7iVmB+qsJQrvLM5Uru1td9r7AfbjeNA==", "1a7ec853-5efc-43cc-903c-6d3aa479d4b5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ee61c07-cf3b-4f36-bd3b-3c75b1dddb96", "AQAAAAIAAYagAAAAEJ6YZv/K6o2SeQ4tHndpHxr02JklLBBxnaxTm8bRas6C4rj11Yeos0zgF+E6WpcQpA==", "dbc1b24f-a04b-4fba-b878-7498218eb993" });
        }
    }
}
