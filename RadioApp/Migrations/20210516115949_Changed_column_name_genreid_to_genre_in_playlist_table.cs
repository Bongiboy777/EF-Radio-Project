using Microsoft.EntityFrameworkCore.Migrations;

namespace RadioDatabase.Migrations
{
    public partial class Changed_column_name_genreid_to_genre_in_playlist_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "PlayList");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "PlayList",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "PlayList");

            migrationBuilder.AddColumn<string>(
                name: "GenreID",
                table: "PlayList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
