using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PGSTask.Web_Jakub_Rzepka.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 17, 16, 0, 8, 877, DateTimeKind.Local), "Test task 3463" },
                    { 2, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 3456" },
                    { 3, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 2345" },
                    { 4, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 3465" },
                    { 5, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 4566" },
                    { 6, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 3456" },
                    { 7, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 2456" },
                    { 8, new DateTime(2019, 7, 17, 16, 0, 8, 880, DateTimeKind.Local), "Test task 1356" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
