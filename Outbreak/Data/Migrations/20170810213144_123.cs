using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Outbreak.Data.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "showVK",
                table: "AspNetUsers",
                newName: "ShowVK");

            migrationBuilder.RenameColumn(
                name: "showSteam",
                table: "AspNetUsers",
                newName: "ShowSteam");

            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ShowVK",
                table: "AspNetUsers",
                newName: "showVK");

            migrationBuilder.RenameColumn(
                name: "ShowSteam",
                table: "AspNetUsers",
                newName: "showSteam");
        }
    }
}
