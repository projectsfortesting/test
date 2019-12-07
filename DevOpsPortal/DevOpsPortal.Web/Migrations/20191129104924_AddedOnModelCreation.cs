using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsPortal.Web.Migrations
{
    public partial class AddedOnModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleGroup_Groups_GroupId",
                table: "ApplicationRoleGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleGroup_AspNetRoles_RoleId",
                table: "ApplicationRoleGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGroup_Groups_GroupId",
                table: "ApplicationUserGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGroup_AspNetUsers_UserId1",
                table: "ApplicationUserGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGroup",
                table: "ApplicationUserGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRoleGroup",
                table: "ApplicationRoleGroup");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRoleGroup_RoleId",
                table: "ApplicationRoleGroup");

            migrationBuilder.RenameTable(
                name: "ApplicationUserGroup",
                newName: "ApplicationUserGroups");

            migrationBuilder.RenameTable(
                name: "ApplicationRoleGroup",
                newName: "ApplicationRoleGroups");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGroup_UserId1",
                table: "ApplicationUserGroups",
                newName: "IX_ApplicationUserGroups_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGroup_GroupId",
                table: "ApplicationUserGroups",
                newName: "IX_ApplicationUserGroups_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRoleGroup_GroupId",
                table: "ApplicationRoleGroups",
                newName: "IX_ApplicationRoleGroups_GroupId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "ApplicationRoleGroups",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ApplicationRoleGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ApplicationRoleGroups",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUserLogins_LoginProvider_ProviderKey",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "UserId", "LoginProvider", "ProviderKey" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ApplicationUserGroups_UserId",
                table: "ApplicationUserGroups",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGroups",
                table: "ApplicationUserGroups",
                columns: new[] { "UserId", "GroupId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ApplicationRoleGroups_Id",
                table: "ApplicationRoleGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRoleGroups",
                table: "ApplicationRoleGroups",
                columns: new[] { "RoleId", "GroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleGroups_ApplicationUserId",
                table: "ApplicationRoleGroups",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRoleGroups_AspNetUsers_ApplicationUserId",
                table: "ApplicationRoleGroups",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRoleGroups_Groups_GroupId",
                table: "ApplicationRoleGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRoleGroups_AspNetRoles_RoleId",
                table: "ApplicationRoleGroups",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGroups_Groups_GroupId",
                table: "ApplicationUserGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGroups_AspNetUsers_UserId1",
                table: "ApplicationUserGroups",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleGroups_AspNetUsers_ApplicationUserId",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleGroups_Groups_GroupId",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleGroups_AspNetRoles_RoleId",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGroups_Groups_GroupId",
                table: "ApplicationUserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGroups_AspNetUsers_UserId1",
                table: "ApplicationUserGroups");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUserLogins_LoginProvider_ProviderKey",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ApplicationUserGroups_UserId",
                table: "ApplicationUserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGroups",
                table: "ApplicationUserGroups");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ApplicationRoleGroups_Id",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRoleGroups",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRoleGroups_ApplicationUserId",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ApplicationRoleGroups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ApplicationRoleGroups");

            migrationBuilder.RenameTable(
                name: "ApplicationUserGroups",
                newName: "ApplicationUserGroup");

            migrationBuilder.RenameTable(
                name: "ApplicationRoleGroups",
                newName: "ApplicationRoleGroup");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGroups_UserId1",
                table: "ApplicationUserGroup",
                newName: "IX_ApplicationUserGroup_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserGroups_GroupId",
                table: "ApplicationUserGroup",
                newName: "IX_ApplicationUserGroup_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRoleGroups_GroupId",
                table: "ApplicationRoleGroup",
                newName: "IX_ApplicationRoleGroup_GroupId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "ApplicationRoleGroup",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGroup",
                table: "ApplicationUserGroup",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRoleGroup",
                table: "ApplicationRoleGroup",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleGroup_RoleId",
                table: "ApplicationRoleGroup",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRoleGroup_Groups_GroupId",
                table: "ApplicationRoleGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRoleGroup_AspNetRoles_RoleId",
                table: "ApplicationRoleGroup",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGroup_Groups_GroupId",
                table: "ApplicationUserGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGroup_AspNetUsers_UserId1",
                table: "ApplicationUserGroup",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
