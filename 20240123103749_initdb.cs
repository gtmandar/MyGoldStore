using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoldStore.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ornaments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<long>(type: "bigint", nullable: false),
                    price = table.Column<long>(type: "bigint", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
