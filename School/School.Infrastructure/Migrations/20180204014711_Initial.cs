using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace School.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(30)", nullable: true),
                    City = table.Column<string>(type: "varchar(30)", nullable: true),
                    State = table.Column<string>(type: "varchar(30)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAddress", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "tblParents",
                columns: table => new
                {
                    ParentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblParents", x => x.ParentId);
                    table.ForeignKey(
                        name: "FK_tblParents_tblAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "tblAddress",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(30)", nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_tblStudents_tblAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "tblAddress",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblParents_AddressId",
                table: "tblParents",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_AddressId",
                table: "tblStudents",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblParents");

            migrationBuilder.DropTable(
                name: "tblStudents");

            migrationBuilder.DropTable(
                name: "tblAddress");
        }
    }
}
