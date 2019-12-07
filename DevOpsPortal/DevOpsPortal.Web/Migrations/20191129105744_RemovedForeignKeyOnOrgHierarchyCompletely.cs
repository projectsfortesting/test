using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsPortal.Web.Migrations
{
    public partial class RemovedForeignKeyOnOrgHierarchyCompletely : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Id",
                table: "OrgHierarchyLevelsUsers");

            migrationBuilder.DropIndex(
                name: "IX_OrgHierarchyLevelsUsers_Id",
                table: "OrgHierarchyLevelsUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrgHierarchyLevelsUsers_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Id",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
