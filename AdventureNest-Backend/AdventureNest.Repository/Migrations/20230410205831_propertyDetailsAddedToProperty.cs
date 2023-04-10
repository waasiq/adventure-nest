using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    public partial class propertyDetailsAddedToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyDetails");

            migrationBuilder.AddColumn<int>(
                name: "BathroomCount",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BedCount",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BedroomCount",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BookingType",
                table: "Properties",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsChair",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDishwasher",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFridge",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSofa",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTable",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTv",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxGuestCount",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhotographsPathList",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "Properties",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BathroomCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BedCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BedroomCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BookingType",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsChair",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsDishwasher",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsFridge",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsSofa",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsTable",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsTv",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "MaxGuestCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PhotographsPathList",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Properties");

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    BathroomCount = table.Column<int>(type: "int", nullable: false),
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    BedroomCount = table.Column<int>(type: "int", nullable: false),
                    BookingType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsChair = table.Column<bool>(type: "bit", nullable: false),
                    IsDishwasher = table.Column<bool>(type: "bit", nullable: false),
                    IsFridge = table.Column<bool>(type: "bit", nullable: false),
                    IsSofa = table.Column<bool>(type: "bit", nullable: false),
                    IsTable = table.Column<bool>(type: "bit", nullable: false),
                    IsTv = table.Column<bool>(type: "bit", nullable: false),
                    MaxGuestCount = table.Column<int>(type: "int", nullable: false),
                    PhotographsPathList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyDetails_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId",
                unique: true);
        }
    }
}
