using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoCleanArch.Infrastructure.Migrations
{
    public partial class AuditEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Todo");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Todo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Todo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Todo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Todo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "TodoId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 10, 36, 761, DateTimeKind.Local).AddTicks(2220), "Migration" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "TodoId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 10, 36, 768, DateTimeKind.Local).AddTicks(1870), "Migration" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "TodoId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 10, 36, 768, DateTimeKind.Local).AddTicks(1931), "Migration" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "TodoId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 10, 36, 768, DateTimeKind.Local).AddTicks(1935), "Migration" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "TodoId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 10, 36, 768, DateTimeKind.Local).AddTicks(1940), "Migration" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Todo");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
