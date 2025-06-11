using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Walkiria.Restrictions.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupTgIdAndChangeUserTgId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Restrictions_TelegramId",
                table: "Restrictions");

            migrationBuilder.RenameColumn(
                name: "TelegramId",
                table: "Restrictions",
                newName: "GroupTgId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Restrictions",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserTgId",
                table: "Restrictions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restrictions",
                table: "Restrictions",
                columns: new[] { "UserTgId", "GroupTgId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Restrictions",
                table: "Restrictions");

            migrationBuilder.DropColumn(
                name: "UserTgId",
                table: "Restrictions");

            migrationBuilder.RenameColumn(
                name: "GroupTgId",
                table: "Restrictions",
                newName: "TelegramId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Restrictions",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.CreateIndex(
                name: "IX_Restrictions_TelegramId",
                table: "Restrictions",
                column: "TelegramId");
        }
    }
}
