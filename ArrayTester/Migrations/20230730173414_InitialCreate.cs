using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrayTester.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Array",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ByteArray = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Array", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortionData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value_0 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_1 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_3 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_4 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_5 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_6 = table.Column<byte>(type: "tinyint", nullable: false),
                    Value_7 = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortionData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Array");

            migrationBuilder.DropTable(
                name: "PortionData");
        }
    }
}
