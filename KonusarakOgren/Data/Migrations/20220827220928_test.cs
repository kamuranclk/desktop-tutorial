using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 169, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 617, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(8523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(6830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(6947));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 617, DateTimeKind.Local).AddTicks(343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 169, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(9468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 47, 25, 616, DateTimeKind.Local).AddTicks(6947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 1, 9, 28, 168, DateTimeKind.Local).AddTicks(6830));
        }
    }
}
