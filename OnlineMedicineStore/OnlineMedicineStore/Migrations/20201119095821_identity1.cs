using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMedicineStore.Migrations
{
    public partial class identity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderMedicine1");

            migrationBuilder.DropTable(
                name: "Order1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order1_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderMedicine1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicinesId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Price_total = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMedicine1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderMedicine1_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderMedicine1_Medicine_MedicinesId",
                        column: x => x.MedicinesId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderMedicine1_Order1_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order1_ApplicationUserId",
                table: "Order1",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMedicine1_ApplicationUserId",
                table: "OrderMedicine1",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMedicine1_MedicinesId",
                table: "OrderMedicine1",
                column: "MedicinesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMedicine1_OrderId",
                table: "OrderMedicine1",
                column: "OrderId");
        }
    }
}
