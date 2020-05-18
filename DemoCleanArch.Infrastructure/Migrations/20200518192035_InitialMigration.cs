using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoCleanArch.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    TodoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.TodoId);
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "TodoId", "Title" },
                values: new object[,]
                {
                    { 1, "Title 1" },
                    { 2, "Title 2" },
                    { 3, "Title 3" },
                    { 4, "Title 4" },
                    { 5, "Title 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
