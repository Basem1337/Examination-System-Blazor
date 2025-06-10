using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class UploadSomeeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc7d9c87-6088-460e-97a6-0359007ffdfa", "AQAAAAIAAYagAAAAEE62WJQq6G2UlG5R0ykVPAYHAr3EqAbjKA2KHfZly/qXsM3SrhxPc2ixrTfNB2cWwQ==", "631a9ac2-fcf2-4ca6-9d1c-94acc46305ff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Inst-01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43e360df-6ea8-48a6-a96b-110b509aa73d", "AQAAAAIAAYagAAAAEJ1pReSR2nT+gm2xKLXBea/5aUgCpkvH4Oy9m4gUkx5xxpgAv46UdNY+isKDP5AtVA==", "dd4e855c-773f-4ae8-b045-4b5df23ef0af" });
        }
    }
}
