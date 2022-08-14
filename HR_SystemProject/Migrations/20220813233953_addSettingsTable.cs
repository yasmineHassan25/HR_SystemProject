using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_SystemProject.Migrations
{
    public partial class addSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "GeneralSetting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bouns = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    vacation1 = table.Column<int>(type: "int", nullable: false),
                    vacation2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSetting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralSetting");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Attendence",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
