using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RadioDatabase.Migrations
{
    public partial class AddedModelCreationConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Genres_GenreId",
                table: "PlayLists");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Users_CreatedByNavigationUserId",
                table: "PlayLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Genres_GenreId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_PlayLists_PlayListId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPlaylists_PlayLists_PlayListId",
                table: "UserPlaylists");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPlaylists_Users_UserId",
                table: "UserPlaylists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayLists",
                table: "PlayLists");

            migrationBuilder.DropIndex(
                name: "IX_PlayLists_CreatedByNavigationUserId",
                table: "PlayLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedByNavigationUserId",
                table: "PlayLists");

            migrationBuilder.RenameTable(
                name: "PlayLists",
                newName: "PlayList");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserPlaylists",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "PlayListId",
                table: "UserPlaylists",
                newName: "PlayListID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserPlaylists",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPlaylists_UserId",
                table: "UserPlaylists",
                newName: "IX_UserPlaylists_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPlaylists_PlayListId",
                table: "UserPlaylists",
                newName: "IX_UserPlaylists_PlayListID");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Tracks",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_GenreId",
                table: "Tracks",
                newName: "IX_Tracks_GenreID");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "PlayList",
                newName: "GenreID");

            migrationBuilder.RenameColumn(
                name: "PlayListId",
                table: "PlayList",
                newName: "PlayListID");

            migrationBuilder.RenameIndex(
                name: "IX_PlayLists_GenreId",
                table: "PlayList",
                newName: "IX_PlayList_GenreID");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genre",
                newName: "GenreID");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('bongiboy777')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "Users",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('qwertyuiop')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('Luwemba')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('Bongani')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(80)",
                unicode: false,
                maxLength: 80,
                nullable: true,
                defaultValueSql: "('bongiluwe777@gmail.com')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "Users",
                type: "datetime",
                nullable: false,
                defaultValueSql: "('2021-05-11')",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tracks",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('Salida')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Tracks",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('KingKay')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PlayList",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('MercyTunes')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PlayList",
                type: "datetime",
                nullable: false,
                defaultValueSql: "('2021-05-11')",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('MercyTunes')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayList",
                table: "PlayList",
                column: "PlayListID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayList_CreatedBy",
                table: "PlayList",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK__PlayList__Create__5441852A",
                table: "PlayList",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK__Tracks__PlayList__5CD6CB2B",
                table: "Tracks",
                column: "PlayListId",
                principalTable: "PlayList",
                principalColumn: "PlayListID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__UserPlayl__PlayL__5AEE82B9",
                table: "UserPlaylists",
                column: "PlayListID",
                principalTable: "PlayList",
                principalColumn: "PlayListID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__UserPlayl__UserI__59FA5E80",
                table: "UserPlaylists",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__PlayList__Create__5441852A",
                table: "PlayList");

            migrationBuilder.DropForeignKey(
                name: "FK__PlayList__GenreI__5629CD9C",
                table: "PlayList");

            migrationBuilder.DropForeignKey(
                name: "FK__Tracks__GenreID__5EBF139D",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK__Tracks__PlayList__5CD6CB2B",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK__UserPlayl__PlayL__5AEE82B9",
                table: "UserPlaylists");

            migrationBuilder.DropForeignKey(
                name: "FK__UserPlayl__UserI__59FA5E80",
                table: "UserPlaylists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayList",
                table: "PlayList");

            migrationBuilder.DropIndex(
                name: "IX_PlayList_CreatedBy",
                table: "PlayList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "PlayList",
                newName: "PlayLists");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserPlaylists",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PlayListID",
                table: "UserPlaylists",
                newName: "PlayListId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "UserPlaylists",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_UserPlaylists_UserID",
                table: "UserPlaylists",
                newName: "IX_UserPlaylists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPlaylists_PlayListID",
                table: "UserPlaylists",
                newName: "IX_UserPlaylists_PlayListId");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Tracks",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_GenreID",
                table: "Tracks",
                newName: "IX_Tracks_GenreId");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "PlayLists",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "PlayListID",
                table: "PlayLists",
                newName: "PlayListId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayList_GenreID",
                table: "PlayLists",
                newName: "IX_PlayLists_GenreId");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('bongiboy777')");

            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('qwertyuiop')");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('Luwemba')");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('Bongani')");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldUnicode: false,
                oldMaxLength: 80,
                oldNullable: true,
                oldDefaultValueSql: "('bongiluwe777@gmail.com')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "('2021-05-11')");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('Salida')");

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('KingKay')");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PlayLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('MercyTunes')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PlayLists",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "('2021-05-11')");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByNavigationUserId",
                table: "PlayLists",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('MercyTunes')");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayLists",
                table: "PlayLists",
                column: "PlayListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_CreatedByNavigationUserId",
                table: "PlayLists",
                column: "CreatedByNavigationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Genres_GenreId",
                table: "PlayLists",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Users_CreatedByNavigationUserId",
                table: "PlayLists",
                column: "CreatedByNavigationUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Genres_GenreId",
                table: "Tracks",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_PlayLists_PlayListId",
                table: "Tracks",
                column: "PlayListId",
                principalTable: "PlayLists",
                principalColumn: "PlayListId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPlaylists_PlayLists_PlayListId",
                table: "UserPlaylists",
                column: "PlayListId",
                principalTable: "PlayLists",
                principalColumn: "PlayListId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPlaylists_Users_UserId",
                table: "UserPlaylists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
