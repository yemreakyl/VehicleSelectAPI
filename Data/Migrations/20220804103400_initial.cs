using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sail = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capasity = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadlightsState = table.Column<bool>(type: "bit", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wheel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    BusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheel_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheel_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Boat",
                columns: new[] { "Id", "Color", "Length", "Material", "Sail" },
                values: new object[,]
                {
                    { 1, "Red", 11, "İron", false },
                    { 2, "Red", 12, "Steel", false },
                    { 3, "White", 10, "Wooden", true },
                    { 4, "White", 13, "Carbon", true },
                    { 5, "White", 11, "Wooden", true },
                    { 6, "Black", 12, "İron", false },
                    { 7, "Black", 12, "Steel", false },
                    { 8, "Blue", 9, "İron", false }
                });

            migrationBuilder.InsertData(
                table: "Bus",
                columns: new[] { "Id", "Capasity", "Color", "Length" },
                values: new object[,]
                {
                    { 1, 100, "Red", 11 },
                    { 2, 80, "Red", 12 },
                    { 3, 60, "White", 10 },
                    { 4, 100, "White", 13 },
                    { 5, 75, "White", 11 },
                    { 6, 90, "Black", 12 },
                    { 7, 85, "Black", 12 },
                    { 8, 69, "Blue", 9 }
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Color", "HeadlightsState", "Model" },
                values: new object[,]
                {
                    { 1, "Wolksvagen", "Red", true, 2018 },
                    { 2, "Ford", "Red", true, 2017 },
                    { 3, "Renault", "White", false, 2014 },
                    { 4, "Wolksvagen", "Blue", true, 2020 },
                    { 5, "Jaguar", "White", false, 2018 },
                    { 6, "Ferrari", "Black", true, 2019 },
                    { 7, "Skoda", "Black", false, 2022 },
                    { 8, "AlfaRomeo", "Blue", true, 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wheel_BusId",
                table: "Wheel",
                column: "BusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wheel_CarId",
                table: "Wheel",
                column: "CarId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boat");

            migrationBuilder.DropTable(
                name: "Wheel");

            migrationBuilder.DropTable(
                name: "Bus");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
