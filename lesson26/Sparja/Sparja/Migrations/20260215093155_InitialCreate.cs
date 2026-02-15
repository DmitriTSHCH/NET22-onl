using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sparja.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SparjaEnjoyerForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MealSparjaCount = table.Column<int>(type: "int", nullable: false),
                    MealDateTimeList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparjaEnjoyerForms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SparjaEnjoyerForms_Email",
                table: "SparjaEnjoyerForms",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SparjaEnjoyerForms");
        }
    }
}
