using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Outbreak.Data.Migrations
{
    public partial class add_vk_comm_temp_doc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "commNick",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "docCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tempNick",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vkLink",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commNick",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "docCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "tempNick",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "vkLink",
                table: "AspNetUsers");
        }
    }
}
