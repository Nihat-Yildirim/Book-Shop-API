using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 905, DateTimeKind.Local).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 354, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 353, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 352, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(362),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 902, DateTimeKind.Local).AddTicks(5709),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(9066),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 349, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(5071),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(4337),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "VarChar(MAX)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 346, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(2070),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(3865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 896, DateTimeKind.Local).AddTicks(8637),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 344, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(5189), new byte[] { 9, 39, 75, 114, 222, 219, 221, 133, 245, 82, 170, 133, 35, 181, 42, 153, 247, 79, 90, 243, 181, 190, 109, 212, 251, 139, 28, 50, 95, 115, 224, 218, 57, 169, 24, 217, 252, 6, 174, 191, 4, 77, 33, 51, 135, 194, 234, 104, 190, 32, 211, 158, 152, 64, 230, 61, 37, 27, 153, 25, 59, 170, 166, 41 }, new byte[] { 31, 230, 32, 226, 66, 141, 60, 100, 183, 251, 67, 83, 127, 152, 60, 137, 175, 158, 56, 230, 219, 15, 130, 201, 1, 207, 187, 139, 175, 33, 121, 165, 137, 211, 227, 150, 150, 75, 2, 24, 29, 194, 14, 46, 213, 142, 254, 65, 88, 161, 166, 88, 226, 82, 169, 147, 88, 29, 126, 83, 16, 43, 224, 138, 116, 98, 228, 134, 18, 132, 44, 200, 58, 233, 146, 222, 103, 189, 51, 224, 87, 43, 37, 209, 94, 178, 144, 195, 252, 111, 233, 253, 100, 236, 176, 106, 124, 140, 240, 86, 70, 253, 184, 213, 38, 209, 46, 149, 154, 34, 220, 50, 39, 239, 134, 69, 132, 99, 95, 231, 223, 253, 76, 225, 191, 75, 232, 105 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 354, DateTimeKind.Local).AddTicks(891),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 905, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 353, DateTimeKind.Local).AddTicks(6895),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 352, DateTimeKind.Local).AddTicks(6848),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(5170),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 902, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(1497),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 349, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(1175),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(5807),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(4202),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "VarChar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(MAX)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 346, DateTimeKind.Local).AddTicks(4577),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(4777),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(9724),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(207),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 344, DateTimeKind.Local).AddTicks(4415),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 896, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(6081), new byte[] { 125, 84, 19, 226, 23, 150, 90, 115, 105, 233, 31, 24, 249, 233, 42, 243, 46, 244, 32, 227, 74, 205, 169, 188, 233, 151, 51, 101, 214, 136, 244, 203, 46, 197, 243, 242, 19, 40, 168, 160, 126, 87, 136, 14, 94, 38, 64, 211, 12, 2, 250, 73, 171, 61, 42, 99, 178, 112, 127, 150, 196, 50, 9, 53 }, new byte[] { 137, 138, 181, 111, 140, 238, 207, 217, 26, 243, 133, 150, 36, 191, 49, 246, 221, 174, 163, 202, 9, 86, 109, 193, 134, 4, 105, 203, 123, 51, 143, 27, 20, 3, 23, 229, 183, 255, 186, 59, 218, 122, 154, 77, 242, 118, 131, 97, 62, 161, 170, 201, 161, 14, 130, 119, 104, 21, 152, 176, 171, 115, 208, 30, 185, 129, 180, 112, 95, 116, 99, 24, 249, 207, 100, 251, 135, 36, 158, 49, 155, 228, 171, 84, 231, 46, 156, 228, 173, 179, 227, 100, 156, 183, 91, 91, 123, 188, 107, 252, 4, 132, 172, 86, 206, 38, 206, 1, 154, 121, 47, 45, 70, 141, 181, 139, 224, 95, 92, 59, 67, 185, 60, 227, 104, 77, 54, 94 } });
        }
    }
}
