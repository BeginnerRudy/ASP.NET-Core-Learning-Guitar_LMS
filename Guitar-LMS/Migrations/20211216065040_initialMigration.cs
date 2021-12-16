using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Guitar_LMS.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuitarPracticeCards",
                columns: table => new
                {
                    DateStr = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarPracticeCards", x => x.DateStr);
                });

            migrationBuilder.CreateTable(
                name: "TodoListItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    DurationInMinute = table.Column<int>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    GuitarPracticeCardDateStr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoListItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TodoListItems_GuitarPracticeCards_GuitarPracticeCardDateStr",
                        column: x => x.GuitarPracticeCardDateStr,
                        principalTable: "GuitarPracticeCards",
                        principalColumn: "DateStr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoListItems_GuitarPracticeCardDateStr",
                table: "TodoListItems",
                column: "GuitarPracticeCardDateStr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoListItems");

            migrationBuilder.DropTable(
                name: "GuitarPracticeCards");
        }
    }
}
