using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iFinanceAPI.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyBalances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyBalances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuarterlyBalanceServiceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearlyBalanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuarterlyBalanceServiceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuarterlyBalanceServiceModel_YearlyBalances_YearlyBalanceId",
                        column: x => x.YearlyBalanceId,
                        principalTable: "YearlyBalances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyBalanceServiceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuarterlyBalanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyBalanceServiceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyBalanceServiceModel_QuarterlyBalanceServiceModel_QuarterlyBalanceId",
                        column: x => x.QuarterlyBalanceId,
                        principalTable: "QuarterlyBalanceServiceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityServiceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyBalanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityServiceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityServiceModel_MonthlyBalanceServiceModel_MonthlyBalanceId",
                        column: x => x.MonthlyBalanceId,
                        principalTable: "MonthlyBalanceServiceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecurringEntityServiceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyBalanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecurringEntityServiceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecurringEntityServiceModel_MonthlyBalanceServiceModel_MonthlyBalanceId",
                        column: x => x.MonthlyBalanceId,
                        principalTable: "MonthlyBalanceServiceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntityServiceModel_MonthlyBalanceId",
                table: "EntityServiceModel",
                column: "MonthlyBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyBalanceServiceModel_QuarterlyBalanceId",
                table: "MonthlyBalanceServiceModel",
                column: "QuarterlyBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuarterlyBalanceServiceModel_YearlyBalanceId",
                table: "QuarterlyBalanceServiceModel",
                column: "YearlyBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_RecurringEntityServiceModel_MonthlyBalanceId",
                table: "RecurringEntityServiceModel",
                column: "MonthlyBalanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityServiceModel");

            migrationBuilder.DropTable(
                name: "RecurringEntityServiceModel");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MonthlyBalanceServiceModel");

            migrationBuilder.DropTable(
                name: "QuarterlyBalanceServiceModel");

            migrationBuilder.DropTable(
                name: "YearlyBalances");
        }
    }
}
