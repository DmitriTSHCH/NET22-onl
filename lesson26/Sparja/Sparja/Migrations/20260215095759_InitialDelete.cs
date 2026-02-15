using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sparja.Migrations
{
    /// <inheritdoc />
    public partial class InitialDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealDateTimeList",
                table: "SparjaEnjoyerForms");

            migrationBuilder.AlterColumn<int>(
                name: "MealSparjaCount",
                table: "SparjaEnjoyerForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MealSparjaCount",
                table: "SparjaEnjoyerForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MealDateTimeList",
                table: "SparjaEnjoyerForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
