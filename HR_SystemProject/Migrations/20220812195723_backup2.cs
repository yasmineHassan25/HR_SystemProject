using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_SystemProject.Migrations
{
    public partial class backup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Attendence",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Attendence");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
