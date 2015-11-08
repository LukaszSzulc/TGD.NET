using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TgdNet.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemModel",
                columns: table => new
                {
                    Id = table.Column<string>(isNullable: false),
                    IsOnSale = table.Column<bool>(isNullable: false),
                    Name = table.Column<string>(isNullable: true),
                    Price = table.Column<decimal>(isNullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ItemModel");
        }
    }
}
