using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class resetPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_registerModels",
                table: "registerModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loginModels",
                table: "loginModels");

            migrationBuilder.RenameTable(
                name: "registerModels",
                newName: "RegisterModels");

            migrationBuilder.RenameTable(
                name: "loginModels",
                newName: "LoginModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisterModels",
                table: "RegisterModels",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginModels",
                table: "LoginModels",
                column: "Email");

            migrationBuilder.CreateTable(
                name: "ResetModel",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResetModel", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResetModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisterModels",
                table: "RegisterModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginModels",
                table: "LoginModels");

            migrationBuilder.RenameTable(
                name: "RegisterModels",
                newName: "registerModels");

            migrationBuilder.RenameTable(
                name: "LoginModels",
                newName: "loginModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registerModels",
                table: "registerModels",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loginModels",
                table: "loginModels",
                column: "Email");
        }
    }
}
