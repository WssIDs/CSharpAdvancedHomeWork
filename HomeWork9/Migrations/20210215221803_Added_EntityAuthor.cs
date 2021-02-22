using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork9.Migrations
{
    public partial class Added_EntityAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlterName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorStory",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    StoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorStory", x => new { x.AuthorsId, x.StoriesId });
                    table.ForeignKey(
                        name: "FK_AuthorStory_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorStory_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AlterName", "FirstName", "LastName" },
                values: new object[] { 1, null, "Reuel ", "Tolkien" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AlterName", "FirstName", "LastName" },
                values: new object[] { 2, null, "Hans", "Andersen" });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorStory_StoriesId",
                table: "AuthorStory",
                column: "StoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorStory");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
