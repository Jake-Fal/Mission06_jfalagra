using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_jfalagra.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    GenresCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_responses_genres_GenresCategoryID",
                        column: x => x.GenresCategoryID,
                        principalTable: "genres",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Horror" });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Action" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "GenresCategoryID", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Andy Muschietti", true, null, null, null, "R", "IT", (ushort)2017 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "GenresCategoryID", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, "Adam McKay", true, null, null, null, "PG-13", "Anchorman", (ushort)2004 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "GenresCategoryID", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "Tony Scott", true, null, null, null, "PG", "Top Gun", (ushort)1986 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_GenresCategoryID",
                table: "responses",
                column: "GenresCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "genres");
        }
    }
}
