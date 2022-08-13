using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_SystemProject.Migrations
{
    public partial class backup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
