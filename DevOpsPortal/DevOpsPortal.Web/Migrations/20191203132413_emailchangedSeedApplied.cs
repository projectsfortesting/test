using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsPortal.Web.Migrations
{
    public partial class emailchangedSeedApplied : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsPasswordReset", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "OrgLevelTypeId", "OrgLevelid", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "User_Active" },
                values: new object[] { "094f3943-725a-4f0e-9f5c-b18c205bed52", 0, "13cec2d8-64fd-4399-9124-ee8b41c4e934", "Plainvanilla@test.com", true, "PlainVanillaFirstName", false, "PlainVanillaLastName", false, null, null, null, 1, 1, 1, null, null, false, null, false, "PlainVanillaUser", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "094f3943-725a-4f0e-9f5c-b18c205bed52", "13cec2d8-64fd-4399-9124-ee8b41c4e934" });
        }
    }
}
