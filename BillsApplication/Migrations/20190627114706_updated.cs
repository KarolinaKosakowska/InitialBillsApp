﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillsApplication.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "Files",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Attachment",
                table: "Files",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
