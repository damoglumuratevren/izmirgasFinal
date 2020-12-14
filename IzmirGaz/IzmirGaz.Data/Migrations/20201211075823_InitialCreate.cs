using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IzmirGaz.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    VisaDuration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyManagerFirstName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CompanyManagerLastName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CompanyManagerPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CompanyPerformanceReport = table.Column<double>(type: "float", nullable: false),
                    PercentageOfGasFired = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PersonelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonelImg = table.Column<string>(type: "nvarchar(250)", maxLength: 50, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPersonnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyPersonnels_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyManagerFirstName", "CompanyManagerLastName", "CompanyManagerPhoneNumber", "CompanyName", "CompanyPerformanceReport", "CompanyPhoneNumber", "CreatedByName", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PercentageOfGasFired", "VisaDuration" },
                values: new object[] { 1, "Anafartalar Mah. Cebeci sok No:11 Ödemiş/İzmir", "Murat Evren", "DAMOĞLU", "232 384 11 29", "Damoğlu Sıhhi Tesisat LTD ŞTI", 0.0, "506 384 11 29", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 979, DateTimeKind.Local).AddTicks(9829), "mevrend@gmail.com", true, false, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(332), "DefaultValue", 0.0, new DateTime(2021, 12, 11, 10, 58, 22, 979, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyManagerFirstName", "CompanyManagerLastName", "CompanyManagerPhoneNumber", "CompanyName", "CompanyPerformanceReport", "CompanyPhoneNumber", "CreatedByName", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PercentageOfGasFired", "VisaDuration" },
                values: new object[] { 2, "MuratBey Mah. Cebeci sok No:11 Ödemiş/İzmir", "Hakan", "Ay", "232 384 55 99", "Öz Sıhhi Tesisat LTD ŞTI", 0.0, "506 555 17 28", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(932), "ozsihhi@gmail.com", true, false, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(934), "DefaultValue", 0.0, new DateTime(2020, 12, 4, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyManagerFirstName", "CompanyManagerLastName", "CompanyManagerPhoneNumber", "CompanyName", "CompanyPerformanceReport", "CompanyPhoneNumber", "CreatedByName", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PercentageOfGasFired", "VisaDuration" },
                values: new object[] { 3, "Nevzat Mah. Cebeci sok No:11 Ödemiş/İzmir", "Hakan", "Ay", "232 384 77 77", "Nevzat Sıhhi Tesisat LTD ŞTI", 0.0, "506 555 77 77", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(945), "nevzat@gmail.com", true, false, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(946), "DefaultValue", 0.0, new DateTime(2021, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.InsertData(
                table: "CompanyPersonnels",
                columns: new[] { "Id", "CompanyId", "CreatedByName", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PersonelImg", "PersonelType", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1026), "Delal Abdullatif", true, false, "Abzak", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1041), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Mühendis", "555 000 00 00" },
                    { 2, 1, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1099), "Atahan", true, false, "Adanır", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1100), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 3, 1, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1105), "Hacı Mehmet", true, false, "Adıgüzel", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1106), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 4, 1, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1110), "Tutkum", true, false, "Ahmadı Asl", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1111), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 5, 2, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1116), "Recep Ali Samet", true, false, "Akdoğan", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1117), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Mühendis", "555 000 00 00" },
                    { 6, 2, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1121), "Ahmet Polat", true, false, "Aklar Çörekçi", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1122), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 7, 2, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1126), "Ecem Hatice", true, false, "Akova", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1128), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 8, 2, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1132), "Selinti", true, false, "Al", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1133), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 9, 3, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1137), "Çisem", true, false, "Atok", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1138), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Mühendis", "555 000 00 00" },
                    { 10, 3, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1143), "Saime", true, false, "Avıandı", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1144), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 11, 3, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1148), "Alçiçek", true, false, "Bad", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1149), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" },
                    { 12, 3, "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1153), "Mustafa Samed", true, false, "Beğenilmiş", "DefaultInsert", new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1155), "DefaultValue", "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png", "Tesisatcı", "555 000 00 00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPersonnels_CompanyId",
                table: "CompanyPersonnels",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyPersonnels");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
