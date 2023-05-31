using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longtitude = table.Column<float>(type: "real", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BookingType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhotographsPathList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxGuestCount = table.Column<int>(type: "int", nullable: false),
                    BedroomCount = table.Column<int>(type: "int", nullable: false),
                    BathroomCount = table.Column<int>(type: "int", nullable: false),
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    IsRefrigerator = table.Column<bool>(type: "bit", nullable: false),
                    IsTv = table.Column<bool>(type: "bit", nullable: false),
                    IsCouch = table.Column<bool>(type: "bit", nullable: false),
                    IsBed = table.Column<bool>(type: "bit", nullable: false),
                    IsGasStove = table.Column<bool>(type: "bit", nullable: false),
                    IsBlender = table.Column<bool>(type: "bit", nullable: false),
                    IsCoffeeMaker = table.Column<bool>(type: "bit", nullable: false),
                    IsMicrowave = table.Column<bool>(type: "bit", nullable: false),
                    IsMixingBowl = table.Column<bool>(type: "bit", nullable: false),
                    IsWashingMachine = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publications_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Picture", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified), "string1@hotmail.com", "string1", "string1", new byte[] { 133, 89, 125, 3, 70, 216, 35, 247, 178, 168, 221, 126, 254, 154, 181, 220, 128, 139, 212, 176, 160, 73, 252, 129, 42, 20, 85, 177, 55, 85, 247, 68, 125, 31, 13, 168, 183, 19, 18, 15, 105, 181, 23, 182, 68, 220, 6, 48, 159, 50, 2, 57, 122, 9, 80, 96, 177, 124, 93, 71, 104, 192, 103, 31 }, new byte[] { 136, 214, 117, 70, 122, 243, 215, 176, 31, 88, 36, 244, 154, 148, 67, 87, 77, 47, 104, 99, 114, 185, 62, 127, 45, 79, 129, 173, 136, 70, 106, 138, 70, 141, 19, 218, 195, 159, 117, 152, 182, 96, 123, 255, 88, 127, 23, 222, 72, 220, 37, 156, 14, 113, 214, 93, 178, 153, 35, 56, 210, 101, 106, 129, 84, 188, 24, 168, 25, 47, 235, 136, 44, 229, 255, 210, 49, 45, 173, 17, 69, 54, 218, 239, 169, 50, 224, 160, 67, 168, 150, 216, 169, 214, 8, 148, 134, 140, 255, 153, 214, 140, 65, 99, 154, 88, 17, 79, 145, 246, 135, 230, 71, 158, 230, 214, 65, 185, 103, 141, 56, 243, 25, 137, 189, 245, 204, 142 }, "string1", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Picture", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2023, 8, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), "string2@hotmail.com", "string2", "string2", new byte[] { 148, 140, 250, 240, 194, 206, 150, 229, 84, 213, 192, 158, 150, 182, 209, 186, 33, 167, 231, 149, 86, 123, 10, 146, 11, 142, 131, 164, 235, 23, 130, 86, 195, 79, 117, 70, 18, 158, 79, 132, 202, 16, 242, 10, 218, 65, 7, 84, 245, 52, 20, 119, 172, 48, 129, 81, 9, 16, 240, 244, 198, 232, 75, 27 }, new byte[] { 56, 159, 183, 5, 52, 242, 219, 6, 155, 139, 68, 4, 120, 73, 185, 57, 171, 25, 194, 195, 93, 124, 100, 69, 180, 61, 96, 51, 176, 159, 178, 69, 176, 199, 73, 176, 140, 29, 102, 4, 254, 218, 121, 149, 40, 94, 159, 39, 233, 1, 215, 173, 72, 68, 87, 211, 20, 8, 76, 210, 57, 99, 134, 96, 126, 33, 28, 195, 60, 119, 2, 14, 38, 142, 20, 35, 133, 247, 9, 184, 145, 145, 196, 76, 24, 33, 174, 100, 194, 32, 127, 170, 240, 163, 182, 50, 226, 182, 106, 20, 150, 82, 52, 246, 97, 226, 107, 61, 29, 4, 16, 9, 229, 31, 241, 149, 202, 39, 0, 184, 168, 248, 27, 159, 182, 111, 114, 105 }, "string2", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Picture", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2023, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), "string3@hotmail.com", "string3", "string3", new byte[] { 24, 172, 120, 216, 222, 81, 93, 118, 34, 73, 252, 0, 16, 90, 223, 137, 11, 54, 126, 177, 253, 136, 149, 105, 60, 145, 71, 10, 254, 231, 97, 237, 41, 213, 36, 3, 237, 242, 71, 61, 17, 72, 131, 96, 173, 210, 166, 220, 172, 252, 225, 43, 42, 67, 63, 126, 108, 163, 46, 77, 255, 149, 51, 152 }, new byte[] { 63, 153, 161, 111, 123, 5, 88, 232, 206, 76, 87, 169, 210, 166, 212, 197, 106, 61, 125, 225, 39, 217, 106, 71, 49, 43, 38, 19, 60, 93, 129, 237, 90, 32, 238, 224, 119, 5, 11, 200, 89, 66, 94, 168, 180, 152, 34, 251, 75, 139, 205, 17, 91, 16, 70, 207, 21, 185, 12, 22, 156, 71, 239, 84, 134, 137, 55, 248, 4, 115, 44, 197, 17, 213, 2, 222, 101, 203, 205, 220, 6, 141, 246, 138, 58, 54, 78, 17, 169, 100, 44, 146, 62, 213, 164, 204, 75, 92, 32, 122, 175, 65, 8, 110, 223, 145, 200, 248, 123, 26, 125, 84, 152, 222, 123, 185, 196, 113, 137, 36, 155, 208, 243, 75, 148, 72, 200, 102 }, "string3", null });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "BathroomCount", "BedCount", "BedroomCount", "BookingType", "City", "Country", "CreatedDate", "IsBed", "IsBlender", "IsCoffeeMaker", "IsCouch", "IsGasStove", "IsMicrowave", "IsMixingBowl", "IsRefrigerator", "IsTv", "IsWashingMachine", "Latitude", "Longtitude", "MaxGuestCount", "Name", "OwnerId", "PhotographsPathList", "PropertyType", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Serdivan", 5, 12, 6, "Full House", "Sakarya", "Turkey", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8455), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 15, "Serdivan Villa", 1, "path1,path2,path3,path4,path5", "Villa", null },
                    { 2, "Miami Beach", 5, 8, 5, "Villa", "Miami", "USA", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8463), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 10, "Miami Villa", 1, "path1,path2,path3,path4,path5", "Villa", null },
                    { 3, "Kadikoy", 1, 3, 4, "Full House", "Istanbul", "Turkey", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8467), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 4, "Istanbul Kadikoy House", 2, "path1,path2,path3,path4,path5", "Flat", null },
                    { 4, "Sosun Magu", 1, 2, 2, "Full House", "Hithadhoo", "Maldives", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8471), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 4, "Maldives Bungalow", 2, "path1,path2,path3,path4,path5", "Villa", null },
                    { 5, "Capitana", 2, 2, 2, "Full House", "Cagliari", "Italy", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8474), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 3, "Sardinia Hotel Room", 3, "path1,path2,path3,path4,path5", "Hotel", null },
                    { 6, "Champ-Elysee", 1, 1, 1, "Single Room", "Paris", "France", new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8476), true, true, true, true, true, true, true, true, true, true, 0f, 0f, 2, "Paris Studio", 3, "path1,path2,path3,path4,path5", "Flat", null }
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Price", "PropertyId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7931), "Villa with Sapanca Lake view", true, 1000m, 1, "Sakarya Lux Villa House", null },
                    { 2, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7944), "Villa with Miami Beach view", true, 4000m, 2, "Ultra Lux Villa in Miami", null },
                    { 3, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7946), "A beautiful house in the center of Kadıköy", true, 800m, 3, "Comfortable House in Kadikoy", null },
                    { 4, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7948), "Ultra luxury all-inclusive accommodation by the ocean in the Maldives", true, 1000m, 4, "Unique Villa with deep blue ocean view", null },
                    { 5, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7949), "A hotel room in the unique beauty of the island of Sardinia", true, 2500m, 5, "All inclusive hotel room with sea view", null },
                    { 6, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(7950), "One room house", true, 200m, 6, "Affordable studio home in Paris", null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "BookingStatus", "CheckInDate", "CreatedDate", "CustomerId", "DepartureDate", "PricePerDay", "PublicationId", "TotalPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8147), "Booked", new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8146), 2, new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 1000m, 1, 6000m, null },
                    { 2, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8250), "Booked", new DateTime(2023, 9, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8250), 3, new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified), 4000m, 2, 16000m, null },
                    { 3, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8262), "Booked", new DateTime(2023, 10, 21, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8262), 1, new DateTime(2023, 10, 27, 10, 30, 0, 0, DateTimeKind.Unspecified), 800m, 3, 48000m, null },
                    { 4, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8272), "Booked", new DateTime(2023, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8271), 3, new DateTime(2023, 8, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), 1000m, 4, 10000m, null },
                    { 5, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8281), "Booked", new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8281), 1, new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 2500m, 5, 15000m, null },
                    { 6, new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8291), "Booked", new DateTime(2023, 5, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 0, 52, 779, DateTimeKind.Local).AddTicks(8290), 2, new DateTime(2023, 5, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), 200m, 6, 800m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PublicationId",
                table: "Bookings",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_PropertyId",
                table: "Publications",
                column: "PropertyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
