using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    public partial class changesInModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ProfilePhotoPath",
                table: "Users",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "FirsName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Publications",
                newName: "Title");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7090), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7124), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7135), new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 109, 18, 54, 121, 200, 147, 55, 202, 54, 215, 243, 8, 250, 83, 231, 97, 28, 100, 90, 147, 234, 129, 73, 30, 234, 6, 122, 65, 255, 148, 207, 76, 89, 43, 249, 29, 128, 66, 177, 102, 95, 114, 17, 135, 166, 75, 54, 55, 177, 87, 178, 54, 106, 54, 201, 229, 37, 238, 211, 200, 122, 75, 103 }, new byte[] { 57, 233, 184, 221, 158, 69, 126, 55, 111, 94, 80, 148, 112, 53, 218, 94, 238, 189, 165, 62, 108, 99, 57, 215, 14, 84, 10, 213, 96, 123, 250, 221, 62, 226, 215, 28, 230, 34, 196, 95, 178, 215, 163, 13, 244, 69, 238, 43, 24, 44, 129, 236, 216, 125, 25, 254, 193, 55, 224, 39, 56, 195, 94, 193, 226, 155, 233, 18, 64, 62, 161, 71, 190, 145, 187, 60, 150, 119, 241, 66, 48, 58, 213, 159, 125, 170, 18, 186, 193, 32, 92, 1, 47, 206, 228, 218, 27, 133, 163, 59, 95, 182, 88, 229, 142, 175, 143, 46, 186, 37, 29, 115, 225, 9, 16, 180, 134, 222, 25, 45, 25, 237, 36, 191, 194, 7, 69, 106 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 0, 241, 138, 72, 244, 201, 9, 44, 87, 250, 23, 107, 32, 106, 192, 113, 35, 26, 166, 228, 50, 12, 242, 87, 187, 193, 89, 129, 197, 83, 192, 1, 40, 0, 61, 15, 225, 153, 127, 33, 37, 240, 8, 220, 213, 75, 157, 235, 69, 195, 55, 59, 170, 133, 172, 169, 136, 166, 167, 202, 70, 156, 234 }, new byte[] { 193, 150, 191, 164, 177, 115, 12, 74, 80, 205, 138, 188, 133, 172, 80, 229, 137, 90, 129, 252, 159, 50, 5, 252, 246, 183, 229, 11, 92, 189, 45, 149, 244, 36, 14, 150, 72, 36, 226, 159, 250, 120, 93, 224, 138, 140, 24, 56, 248, 212, 69, 84, 249, 31, 84, 253, 253, 150, 5, 184, 163, 32, 115, 1, 187, 253, 182, 96, 31, 251, 90, 209, 176, 247, 218, 7, 54, 251, 85, 190, 214, 232, 158, 41, 49, 153, 57, 221, 53, 51, 108, 157, 10, 8, 120, 150, 206, 238, 208, 49, 119, 50, 210, 139, 223, 136, 20, 234, 118, 97, 85, 83, 233, 173, 185, 122, 173, 207, 205, 9, 174, 255, 81, 10, 192, 142, 211, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 3, 169, 17, 30, 11, 78, 206, 168, 12, 182, 210, 144, 134, 130, 60, 29, 122, 137, 146, 31, 60, 129, 19, 21, 38, 101, 139, 229, 9, 203, 166, 71, 77, 109, 48, 102, 248, 79, 181, 237, 29, 42, 86, 73, 41, 174, 159, 50, 192, 105, 148, 233, 239, 227, 144, 22, 92, 0, 52, 31, 189, 13, 52 }, new byte[] { 116, 46, 6, 76, 4, 66, 203, 20, 149, 120, 78, 164, 192, 209, 175, 219, 134, 10, 184, 7, 246, 9, 119, 65, 24, 195, 20, 77, 150, 167, 68, 231, 100, 95, 160, 95, 28, 20, 101, 9, 148, 78, 0, 112, 213, 94, 45, 37, 46, 30, 3, 205, 57, 191, 173, 239, 144, 84, 50, 220, 5, 232, 172, 57, 161, 164, 179, 156, 252, 13, 93, 138, 121, 155, 37, 78, 217, 97, 101, 243, 116, 21, 225, 229, 241, 201, 109, 216, 188, 236, 113, 126, 27, 144, 41, 221, 39, 179, 186, 8, 62, 238, 194, 151, 105, 246, 22, 75, 206, 175, 173, 196, 117, 109, 156, 223, 42, 34, 23, 241, 224, 98, 148, 11, 105, 83, 85, 178 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Users",
                newName: "ProfilePhotoPath");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "FirsName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Publications",
                newName: "Header");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1999, 9, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), new byte[] { 112, 215, 111, 108, 228, 102, 216, 135, 42, 223, 239, 54, 141, 38, 165, 28, 16, 98, 153, 43, 49, 163, 212, 128, 110, 89, 241, 143, 105, 49, 50, 51, 103, 20, 99, 24, 124, 0, 128, 130, 224, 5, 128, 185, 14, 19, 207, 226, 137, 133, 243, 104, 250, 255, 255, 208, 227, 53, 144, 103, 240, 125, 249, 64 }, new byte[] { 137, 219, 177, 245, 203, 29, 80, 170, 0, 193, 52, 123, 76, 234, 119, 156, 45, 158, 85, 84, 27, 250, 22, 215, 245, 102, 161, 129, 223, 73, 207, 205, 172, 99, 195, 206, 169, 83, 168, 78, 121, 108, 188, 85, 138, 201, 20, 126, 111, 23, 190, 117, 33, 63, 20, 83, 202, 64, 232, 105, 223, 132, 174, 142, 41, 46, 252, 126, 111, 20, 235, 24, 152, 119, 110, 235, 18, 52, 146, 7, 188, 252, 72, 66, 221, 246, 35, 20, 198, 78, 107, 57, 233, 100, 7, 68, 234, 138, 48, 9, 105, 32, 15, 170, 224, 253, 154, 114, 181, 107, 48, 174, 229, 34, 166, 79, 156, 173, 134, 250, 19, 56, 139, 55, 32, 130, 207, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1998, 8, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), new byte[] { 2, 87, 38, 185, 13, 13, 156, 23, 102, 18, 133, 80, 255, 88, 127, 161, 214, 241, 113, 63, 4, 136, 112, 33, 220, 2, 127, 95, 156, 170, 35, 45, 33, 134, 43, 20, 42, 231, 175, 62, 14, 55, 2, 92, 196, 200, 248, 57, 131, 182, 7, 203, 120, 132, 7, 244, 238, 182, 169, 221, 223, 203, 14, 114 }, new byte[] { 190, 172, 5, 106, 144, 70, 132, 248, 28, 44, 253, 160, 172, 119, 194, 180, 173, 216, 110, 238, 17, 203, 206, 5, 227, 195, 224, 182, 211, 159, 249, 254, 165, 106, 40, 165, 118, 118, 74, 150, 242, 157, 69, 130, 160, 37, 242, 190, 51, 133, 1, 24, 232, 104, 166, 36, 26, 139, 80, 111, 199, 211, 135, 136, 195, 143, 8, 30, 72, 21, 86, 172, 173, 113, 199, 225, 181, 45, 249, 87, 63, 183, 115, 5, 170, 30, 122, 161, 44, 18, 97, 69, 4, 89, 18, 25, 45, 70, 66, 210, 15, 62, 81, 18, 46, 4, 28, 177, 37, 37, 147, 210, 73, 126, 217, 44, 2, 100, 9, 82, 65, 167, 189, 121, 191, 117, 1, 159 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1997, 7, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new byte[] { 244, 94, 112, 254, 82, 181, 148, 40, 144, 128, 111, 192, 243, 9, 113, 170, 215, 254, 244, 140, 76, 6, 194, 236, 185, 65, 240, 212, 23, 152, 55, 214, 151, 85, 80, 184, 64, 171, 113, 18, 48, 184, 158, 172, 192, 161, 217, 161, 123, 105, 219, 252, 13, 214, 51, 118, 126, 163, 135, 75, 111, 247, 221, 1 }, new byte[] { 169, 189, 66, 133, 85, 144, 255, 129, 75, 149, 90, 155, 153, 61, 159, 161, 7, 154, 205, 74, 147, 86, 238, 182, 120, 51, 201, 123, 120, 199, 86, 255, 202, 64, 67, 173, 234, 246, 209, 199, 241, 134, 206, 0, 12, 147, 48, 233, 249, 131, 30, 125, 91, 106, 73, 53, 82, 11, 239, 225, 82, 32, 22, 34, 195, 127, 171, 62, 80, 206, 99, 50, 165, 11, 202, 41, 191, 233, 174, 22, 195, 45, 240, 180, 85, 31, 4, 79, 96, 176, 126, 174, 231, 159, 132, 198, 213, 83, 182, 125, 64, 96, 114, 158, 123, 117, 124, 168, 134, 99, 76, 45, 2, 80, 164, 192, 208, 39, 227, 227, 189, 236, 127, 0, 60, 164, 70, 122 } });
        }
    }
}
