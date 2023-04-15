using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    public partial class seedDatasAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedDate", "Email", "FirsName", "LastName", "PasswordHash", "PasswordSalt", "ProfilePhotoPath", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1999, 9, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified), "string1@hotmail.com", "string1", "string1", new byte[] { 112, 215, 111, 108, 228, 102, 216, 135, 42, 223, 239, 54, 141, 38, 165, 28, 16, 98, 153, 43, 49, 163, 212, 128, 110, 89, 241, 143, 105, 49, 50, 51, 103, 20, 99, 24, 124, 0, 128, 130, 224, 5, 128, 185, 14, 19, 207, 226, 137, 133, 243, 104, 250, 255, 255, 208, 227, 53, 144, 103, 240, 125, 249, 64 }, new byte[] { 137, 219, 177, 245, 203, 29, 80, 170, 0, 193, 52, 123, 76, 234, 119, 156, 45, 158, 85, 84, 27, 250, 22, 215, 245, 102, 161, 129, 223, 73, 207, 205, 172, 99, 195, 206, 169, 83, 168, 78, 121, 108, 188, 85, 138, 201, 20, 126, 111, 23, 190, 117, 33, 63, 20, 83, 202, 64, 232, 105, 223, 132, 174, 142, 41, 46, 252, 126, 111, 20, 235, 24, 152, 119, 110, 235, 18, 52, 146, 7, 188, 252, 72, 66, 221, 246, 35, 20, 198, 78, 107, 57, 233, 100, 7, 68, 234, 138, 48, 9, 105, 32, 15, 170, 224, 253, 154, 114, 181, 107, 48, 174, 229, 34, 166, 79, 156, 173, 134, 250, 19, 56, 139, 55, 32, 130, 207, 93 }, "string1", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedDate", "Email", "FirsName", "LastName", "PasswordHash", "PasswordSalt", "ProfilePhotoPath", "UpdatedDate" },
                values: new object[] { 2, new DateTime(1998, 8, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), "string2@hotmail.com", "string2", "string2", new byte[] { 2, 87, 38, 185, 13, 13, 156, 23, 102, 18, 133, 80, 255, 88, 127, 161, 214, 241, 113, 63, 4, 136, 112, 33, 220, 2, 127, 95, 156, 170, 35, 45, 33, 134, 43, 20, 42, 231, 175, 62, 14, 55, 2, 92, 196, 200, 248, 57, 131, 182, 7, 203, 120, 132, 7, 244, 238, 182, 169, 221, 223, 203, 14, 114 }, new byte[] { 190, 172, 5, 106, 144, 70, 132, 248, 28, 44, 253, 160, 172, 119, 194, 180, 173, 216, 110, 238, 17, 203, 206, 5, 227, 195, 224, 182, 211, 159, 249, 254, 165, 106, 40, 165, 118, 118, 74, 150, 242, 157, 69, 130, 160, 37, 242, 190, 51, 133, 1, 24, 232, 104, 166, 36, 26, 139, 80, 111, 199, 211, 135, 136, 195, 143, 8, 30, 72, 21, 86, 172, 173, 113, 199, 225, 181, 45, 249, 87, 63, 183, 115, 5, 170, 30, 122, 161, 44, 18, 97, 69, 4, 89, 18, 25, 45, 70, 66, 210, 15, 62, 81, 18, 46, 4, 28, 177, 37, 37, 147, 210, 73, 126, 217, 44, 2, 100, 9, 82, 65, 167, 189, 121, 191, 117, 1, 159 }, "string2", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedDate", "Email", "FirsName", "LastName", "PasswordHash", "PasswordSalt", "ProfilePhotoPath", "UpdatedDate" },
                values: new object[] { 3, new DateTime(1997, 7, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), "string3@hotmail.com", "string3", "string3", new byte[] { 244, 94, 112, 254, 82, 181, 148, 40, 144, 128, 111, 192, 243, 9, 113, 170, 215, 254, 244, 140, 76, 6, 194, 236, 185, 65, 240, 212, 23, 152, 55, 214, 151, 85, 80, 184, 64, 171, 113, 18, 48, 184, 158, 172, 192, 161, 217, 161, 123, 105, 219, 252, 13, 214, 51, 118, 126, 163, 135, 75, 111, 247, 221, 1 }, new byte[] { 169, 189, 66, 133, 85, 144, 255, 129, 75, 149, 90, 155, 153, 61, 159, 161, 7, 154, 205, 74, 147, 86, 238, 182, 120, 51, 201, 123, 120, 199, 86, 255, 202, 64, 67, 173, 234, 246, 209, 199, 241, 134, 206, 0, 12, 147, 48, 233, 249, 131, 30, 125, 91, 106, 73, 53, 82, 11, 239, 225, 82, 32, 22, 34, 195, 127, 171, 62, 80, 206, 99, 50, 165, 11, 202, 41, 191, 233, 174, 22, 195, 45, 240, 180, 85, 31, 4, 79, 96, 176, 126, 174, 231, 159, 132, 198, 213, 83, 182, 125, 64, 96, 114, 158, 123, 117, 124, 168, 134, 99, 76, 45, 2, 80, 164, 192, 208, 39, 227, 227, 189, 236, 127, 0, 60, 164, 70, 122 }, "string3", null });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "BathroomCount", "BedCount", "BedroomCount", "BookingType", "City", "Country", "CreatedDate", "IsChair", "IsDishwasher", "IsFridge", "IsSofa", "IsTable", "IsTv", "Latitude", "Longtitude", "MaxGuestCount", "Name", "OwnerId", "PhotographsPathList", "PropertyType", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Serdivan", 5, 12, 6, "Full House", "Sakarya", "Turkey", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(639), true, true, true, true, true, true, 0f, 0f, 15, "Serdivan Villa", 1, "path1,path2,path3,path4,path5", "Villa", null },
                    { 2, "Miami Beach", 5, 8, 5, "Villa", "Miami", "USA", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(642), true, true, true, true, true, true, 0f, 0f, 10, "Miami Villa", 1, "path1,path2,path3,path4,path5", "Villa", null },
                    { 3, "Kadikoy", 1, 3, 4, "Full House", "Istanbul", "Turkey", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(645), true, true, true, true, true, true, 0f, 0f, 4, "Istanbul Kadikoy House", 2, "path1,path2,path3,path4,path5", "Flat", null },
                    { 4, "Sosun Magu", 1, 2, 2, "Full House", "Hithadhoo", "Maldives", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(647), true, false, true, false, true, true, 0f, 0f, 4, "Maldives Bungalow", 2, "path1,path2,path3,path4,path5", "Villa", null },
                    { 5, "Capitana", 2, 2, 2, "Full House", "Cagliari", "Italy", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(684), true, true, true, true, true, true, 0f, 0f, 3, "Sardinia Hotel Room", 3, "path1,path2,path3,path4,path5", "Hotel", null },
                    { 6, "Champ-Elysee", 1, 1, 1, "Single Room", "Paris", "France", new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(688), false, true, true, true, false, false, 0f, 0f, 2, "Paris Studio", 3, "path1,path2,path3,path4,path5", "Flat", null }
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "CreatedDate", "Description", "Header", "IsActive", "Price", "PropertyId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(30), "Villa with Sapanca Lake view", "Sakarya Lux Villa House", true, 1000m, 1, null },
                    { 2, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(40), "Villa with Miami Beach view", "Ultra Lux Villa in Miami", true, 4000m, 2, null },
                    { 3, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(41), "A beautiful house in the center of Kadıköy", "Comfortable House in Kadikoy", true, 800m, 3, null },
                    { 4, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(42), "Ultra luxury all-inclusive accommodation by the ocean in the Maldives", "Unique Villa with deep blue ocean view", true, 1000m, 4, null },
                    { 5, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(43), "A hotel room in the unique beauty of the island of Sardinia", "All inclusive hotel room with sea view", true, 2500m, 5, null },
                    { 6, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(44), "One room house", "Affordable studio home in Paris", true, 200m, 6, null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "BookingStatus", "CheckInDate", "CreatedDate", "CustomerId", "DepartureDate", "PricePerDay", "PublicationId", "TotalPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(305), "Booked", new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(304), 2, new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 1000m, 1, 6000m, null },
                    { 2, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(466), "Booked", new DateTime(2023, 9, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(465), 3, new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified), 4000m, 2, 16000m, null },
                    { 3, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476), "Booked", new DateTime(2023, 10, 21, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476), 1, new DateTime(2023, 10, 27, 10, 30, 0, 0, DateTimeKind.Unspecified), 800m, 3, 48000m, null },
                    { 4, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485), "Booked", new DateTime(2023, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485), 3, new DateTime(2023, 8, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), 1000m, 4, 10000m, null },
                    { 5, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493), "Booked", new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493), 1, new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 2500m, 5, 15000m, null },
                    { 6, new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(502), "Booked", new DateTime(2023, 5, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(501), 2, new DateTime(2023, 5, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), 200m, 6, 800m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
