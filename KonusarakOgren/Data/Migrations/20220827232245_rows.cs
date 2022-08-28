using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class rows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 988, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 988, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AddColumn<int>(
                name: "Rows",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 580, DateTimeKind.Local).AddTicks(9190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.AddColumn<int>(
                name: "Rows",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 580, DateTimeKind.Local).AddTicks(7654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(114));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rows",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Rows",
                table: "Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 988, DateTimeKind.Local).AddTicks(2396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 988, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 581, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(1417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 580, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 15, 8, 987, DateTimeKind.Local).AddTicks(114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 2, 22, 45, 580, DateTimeKind.Local).AddTicks(7654));
        }
    }
}
