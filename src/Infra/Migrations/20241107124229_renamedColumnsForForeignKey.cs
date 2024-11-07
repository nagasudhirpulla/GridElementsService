﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class renamedColumnsForForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubstationId1",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "SubstationId2",
                table: "Elements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubstationId1",
                table: "Elements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubstationId2",
                table: "Elements",
                type: "INTEGER",
                nullable: true);
        }
    }
}
