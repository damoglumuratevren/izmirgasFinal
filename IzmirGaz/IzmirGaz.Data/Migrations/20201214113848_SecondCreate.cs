using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IzmirGaz.Data.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonelImg",
                table: "CompanyPersonnels",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "PersonelEmail",
                table: "CompanyPersonnels",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompanyCertificateEndDate",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CompanyCountry",
                table: "Companies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CompanyCertificateEndDate", "CompanyCountry", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "Anafartalar Mah. Cebeci sok No:11", new DateTime(2022, 12, 14, 14, 38, 47, 761, DateTimeKind.Local).AddTicks(9108), "Ödemiş", new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(6149), new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(7345), new DateTime(2021, 12, 14, 14, 38, 47, 761, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CompanyCertificateEndDate", "CompanyCountry", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "MuratBey Mah. Cebeci sok No:11", new DateTime(2023, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8581), "Tire", new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8787), new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8790), new DateTime(2020, 12, 7, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CompanyCertificateEndDate", "CompanyCountry", "CompanyManagerFirstName", "CompanyManagerLastName", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "Nevzat Mah. Cebeci sok No:11", new DateTime(2025, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8803), "Bornova", "Nevzat", "KadirAy", new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8813), new DateTime(2020, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8815), new DateTime(2021, 12, 14, 14, 38, 47, 762, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1735), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1768), "default@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1905), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1908), "default1@gmail.com", "555 000 00 01" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1918), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1921), "default2@gmail.com", "555 000 00 02" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1929), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1931), "default3@gmail.com", "555 000 00 03" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1939), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1941), "default4@gmail.com", "555 000 00 04" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1950), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1952), "default5@gmail.com", "555 000 00 05" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1960), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1962), "default6@gmail.com", "555 000 00 06" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1970), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1973), "default7@gmail.com", "555 000 00 07" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1980), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1983), "default8@gmail.com", "555 000 00 08" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(1994), "default9@gmail.com", "555 000 00 09" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(2001), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(2004), "default10@gmail.com", "555 000 00 10" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate", "PersonelEmail", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(2011), new DateTime(2020, 12, 14, 14, 38, 47, 776, DateTimeKind.Local).AddTicks(2014), "default11@gmail.com", "555 000 00 11" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPersonnels_PersonelEmail",
                table: "CompanyPersonnels",
                column: "PersonelEmail",
                unique: true,
                filter: "[PersonelEmail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPersonnels_PhoneNumber",
                table: "CompanyPersonnels",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyManagerPhoneNumber",
                table: "Companies",
                column: "CompanyManagerPhoneNumber",
                unique: true,
                filter: "[CompanyManagerPhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyPhoneNumber",
                table: "Companies",
                column: "CompanyPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Email",
                table: "Companies",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CompanyPersonnels_PersonelEmail",
                table: "CompanyPersonnels");

            migrationBuilder.DropIndex(
                name: "IX_CompanyPersonnels_PhoneNumber",
                table: "CompanyPersonnels");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyManagerPhoneNumber",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyPhoneNumber",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Email",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "PersonelEmail",
                table: "CompanyPersonnels");

            migrationBuilder.DropColumn(
                name: "CompanyCertificateEndDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyCountry",
                table: "Companies");

            migrationBuilder.AlterColumn<string>(
                name: "PersonelImg",
                table: "CompanyPersonnels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "Anafartalar Mah. Cebeci sok No:11 Ödemiş/İzmir", new DateTime(2020, 12, 11, 10, 58, 22, 979, DateTimeKind.Local).AddTicks(9829), new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(332), new DateTime(2021, 12, 11, 10, 58, 22, 979, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "MuratBey Mah. Cebeci sok No:11 Ödemiş/İzmir", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(932), new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(934), new DateTime(2020, 12, 4, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CompanyManagerFirstName", "CompanyManagerLastName", "CreatedDate", "ModifiedDate", "VisaDuration" },
                values: new object[] { "Nevzat Mah. Cebeci sok No:11 Ödemiş/İzmir", "Hakan", "Ay", new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(945), new DateTime(2020, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(946), new DateTime(2021, 12, 11, 10, 58, 22, 980, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1026), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1099), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1100), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1105), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1106), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1110), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1111), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1116), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1117), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1121), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1122), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1126), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1128), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1132), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1133), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1137), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1138), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1143), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1144), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1148), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1149), "555 000 00 00" });

            migrationBuilder.UpdateData(
                table: "CompanyPersonnels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1153), new DateTime(2020, 12, 11, 10, 58, 22, 986, DateTimeKind.Local).AddTicks(1155), "555 000 00 00" });
        }
    }
}
