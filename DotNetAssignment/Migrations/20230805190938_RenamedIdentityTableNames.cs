using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetAssignment.Migrations
{
    public partial class RenamedIdentityTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                schema: "Assignments",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                schema: "Assignments",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "Assignments",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                schema: "Assignments",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                schema: "Assignments",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                schema: "Assignments",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                schema: "Assignments",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                schema: "Assignments",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "Assignments",
                newName: "UserTokens",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "Assignments",
                newName: "UserRoles",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "Assignments",
                newName: "UserLogins",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "Assignments",
                newName: "UserClaims",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "Assignments",
                newName: "Role",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "Assignments",
                newName: "RoleClaims",
                newSchema: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Assignments",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Assignments",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Assignments",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Assignments",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "Assignments",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Assignments",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "Assignments",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "Assignments",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                schema: "Assignments",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Assignments",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Assignments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Assignments",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "Assignments",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Assignments",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "Assignments",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Assignments",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Assignments",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                schema: "Assignments",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "Assignments",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Assignments",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "Assignments",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "Assignments",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Assignments",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                schema: "Assignments",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Assignments",
                newName: "AspNetUserTokens",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Assignments",
                newName: "AspNetUserRoles",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Assignments",
                newName: "AspNetUserLogins",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Assignments",
                newName: "AspNetUserClaims",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Assignments",
                newName: "AspNetRoleClaims",
                newSchema: "Assignments");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Assignments",
                newName: "AspNetRoles",
                newSchema: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Assignments",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                schema: "Assignments",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                schema: "Assignments",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Assignments",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "Assignments",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                schema: "Assignments",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                schema: "Assignments",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                schema: "Assignments",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                schema: "Assignments",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                schema: "Assignments",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                schema: "Assignments",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalSchema: "Assignments",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserLogins",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                schema: "Assignments",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalSchema: "Assignments",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserRoles",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "Assignments",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "Assignments",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
