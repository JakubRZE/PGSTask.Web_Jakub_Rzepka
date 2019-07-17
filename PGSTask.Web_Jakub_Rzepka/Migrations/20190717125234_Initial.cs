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
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    IsDone = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDone" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 17, 14, 52, 34, 527, DateTimeKind.Local), "Test task 3463", false },
                    { 2, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 3456", false },
                    { 3, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 2345", false },
                    { 4, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 3465", false },
                    { 5, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 4566", false },
                    { 6, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 3456", false },
                    { 7, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 2456", false },
                    { 8, new DateTime(2019, 7, 17, 14, 52, 34, 530, DateTimeKind.Local), "Test task 1356", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
