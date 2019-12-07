using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsPortal.Web.Migrations
{
    public partial class RemovedForiegnKeyOrgTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_OrgLevels_Id",
                table: "OrgHierarchyLevelsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Org_Id",
                table: "OrgHierarchyLevelsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgLevels_OrgLevelTypes_OrgLevelTypeId",
                table: "OrgLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgLevels_Organizations_Org_Id",
                table: "OrgLevels");

            migrationBuilder.DropIndex(
                name: "IX_OrgLevels_OrgLevelTypeId",
                table: "OrgLevels");

            migrationBuilder.DropIndex(
                name: "IX_OrgLevels_Org_Id",
                table: "OrgLevels");

            migrationBuilder.DropIndex(
                name: "IX_OrgHierarchyLevelsUsers_Org_Id",
                table: "OrgHierarchyLevelsUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrgLevels",
                newName: "PId");

            migrationBuilder.AddColumn<int>(
                name: "OrgId",
                table: "OrgLevels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrgLevelTypestypeId",
                table: "OrgLevels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrgLevels_OrgId",
                table: "OrgLevels",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgLevels_OrgLevelTypestypeId",
                table: "OrgLevels",
                column: "OrgLevelTypestypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Id",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgLevels_Organizations_OrgId",
                table: "OrgLevels",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgLevels_OrgLevelTypes_OrgLevelTypestypeId",
                table: "OrgLevels",
                column: "OrgLevelTypestypeId",
                principalTable: "OrgLevelTypes",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Id",
                table: "OrgHierarchyLevelsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgLevels_Organizations_OrgId",
                table: "OrgLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgLevels_OrgLevelTypes_OrgLevelTypestypeId",
                table: "OrgLevels");

            migrationBuilder.DropIndex(
                name: "IX_OrgLevels_OrgId",
                table: "OrgLevels");

            migrationBuilder.DropIndex(
                name: "IX_OrgLevels_OrgLevelTypestypeId",
                table: "OrgLevels");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "OrgLevels");

            migrationBuilder.DropColumn(
                name: "OrgLevelTypestypeId",
                table: "OrgLevels");

            migrationBuilder.RenameColumn(
                name: "PId",
                table: "OrgLevels",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrgLevels_OrgLevelTypeId",
                table: "OrgLevels",
                column: "OrgLevelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgLevels_Org_Id",
                table: "OrgLevels",
                column: "Org_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrgHierarchyLevelsUsers_Org_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Org_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_OrgLevels_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Id",
                principalTable: "OrgLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgHierarchyLevelsUsers_Organizations_Org_Id",
                table: "OrgHierarchyLevelsUsers",
                column: "Org_Id",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgLevels_OrgLevelTypes_OrgLevelTypeId",
                table: "OrgLevels",
                column: "OrgLevelTypeId",
                principalTable: "OrgLevelTypes",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgLevels_Organizations_Org_Id",
                table: "OrgLevels",
                column: "Org_Id",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
