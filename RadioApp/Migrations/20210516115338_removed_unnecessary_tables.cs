using Microsoft.EntityFrameworkCore.Migrations;

namespace RadioDatabase.Migrations
{
    public partial class removed_unnecessary_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__PlayList__GenreI__5629CD9C",
                table: "PlayList");

            migrationBuilder.DropForeignKey(
                name: "FK__Tracks__GenreID__5EBF139D",
                table: "Tracks");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "UserPlaylists");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_GenreID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_PlayList_GenreID",
                table: "PlayList");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Tracks");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Tracks",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "GenreID",
                table: "PlayList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Tracks");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "PlayList",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('MercyTunes')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "UserPlaylists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayListID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlaylists", x => x.ID);
                    table.ForeignKey(
                        name: "FK__UserPlayl__PlayL__5AEE82B9",
                        column: x => x.PlayListID,
                        principalTable: "PlayList",
                        principalColumn: "PlayListID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__UserPlayl__UserI__59FA5E80",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_GenreID",
                table: "Tracks",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayList_GenreID",
                table: "PlayList",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlaylists_PlayListID",
                table: "UserPlaylists",
                column: "PlayListID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlaylists_UserID",
                table: "UserPlaylists",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__PlayList__GenreI__5629CD9C",
                table: "PlayList",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Tracks__GenreID__5EBF139D",
                table: "Tracks",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
