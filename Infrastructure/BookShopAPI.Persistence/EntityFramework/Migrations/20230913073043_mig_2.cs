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
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(6245),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 383, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(7982),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 382, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(4551),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 381, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 346, DateTimeKind.Local).AddTicks(9007),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 374, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(9353),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 373, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(5564),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 372, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(1787),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 372, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 344, DateTimeKind.Local).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 371, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(7599),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 370, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 370, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(1833),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(4452),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Comments",
                type: "VarChar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(9442),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(7135),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 367, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(4758),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 367, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(9486),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(3915),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(5678),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(235),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 365, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(8980), new byte[] { 149, 160, 231, 154, 153, 130, 163, 84, 241, 213, 86, 255, 188, 198, 87, 211, 32, 10, 193, 141, 8, 137, 224, 65, 213, 42, 46, 231, 236, 226, 14, 226, 9, 119, 195, 228, 223, 49, 38, 98, 78, 13, 101, 139, 149, 211, 77, 42, 20, 143, 191, 6, 156, 178, 127, 191, 193, 161, 192, 23, 129, 146, 75, 64 }, new byte[] { 129, 250, 30, 170, 87, 75, 140, 181, 197, 129, 234, 48, 197, 83, 82, 206, 16, 108, 171, 190, 168, 194, 205, 39, 121, 224, 86, 37, 154, 98, 208, 179, 1, 89, 233, 134, 66, 178, 202, 51, 130, 95, 209, 125, 135, 123, 165, 15, 130, 121, 58, 53, 245, 133, 17, 229, 156, 205, 239, 245, 200, 7, 216, 96, 45, 55, 101, 16, 112, 183, 227, 160, 45, 34, 190, 99, 249, 245, 220, 112, 173, 135, 184, 157, 160, 187, 98, 151, 125, 53, 143, 181, 44, 46, 104, 2, 39, 79, 159, 75, 29, 201, 104, 208, 164, 243, 23, 117, 29, 50, 106, 12, 186, 168, 231, 114, 239, 222, 63, 65, 194, 45, 95, 80, 96, 196, 69, 69 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 383, DateTimeKind.Local).AddTicks(6416),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 382, DateTimeKind.Local).AddTicks(3109),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 381, DateTimeKind.Local).AddTicks(8189),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 374, DateTimeKind.Local).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 346, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 373, DateTimeKind.Local).AddTicks(1948),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 372, DateTimeKind.Local).AddTicks(8127),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 372, DateTimeKind.Local).AddTicks(2421),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 371, DateTimeKind.Local).AddTicks(6708),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 344, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 370, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 370, DateTimeKind.Local).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(5381),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(8853),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Comments",
                type: "VarChar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(3100),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(3222),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 367, DateTimeKind.Local).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 367, DateTimeKind.Local).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(5404),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(9504),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 366, DateTimeKind.Local).AddTicks(1861),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 18, 33, 365, DateTimeKind.Local).AddTicks(6556),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 22, 18, 33, 368, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 22, 18, 33, 369, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 22, 18, 33, 383, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 18, 33, 383, DateTimeKind.Local).AddTicks(8846), new byte[] { 131, 192, 207, 90, 208, 147, 38, 119, 231, 50, 145, 141, 54, 20, 97, 113, 91, 77, 77, 198, 240, 103, 174, 187, 206, 246, 175, 43, 10, 49, 200, 141, 3, 229, 151, 128, 19, 10, 241, 51, 114, 1, 214, 96, 8, 207, 57, 46, 13, 224, 227, 231, 103, 210, 22, 176, 211, 47, 210, 155, 179, 180, 78, 3 }, new byte[] { 41, 194, 73, 252, 97, 90, 47, 245, 171, 69, 239, 19, 104, 213, 171, 146, 167, 181, 92, 109, 116, 221, 105, 139, 243, 181, 220, 19, 66, 212, 252, 99, 222, 171, 98, 85, 144, 101, 144, 78, 113, 50, 175, 118, 60, 145, 184, 246, 227, 131, 185, 226, 147, 29, 18, 14, 65, 132, 139, 132, 12, 162, 142, 202, 195, 83, 220, 157, 203, 93, 100, 137, 205, 81, 79, 82, 137, 41, 160, 63, 201, 102, 45, 204, 184, 209, 126, 12, 87, 156, 212, 55, 205, 214, 110, 126, 29, 0, 156, 187, 53, 98, 211, 135, 92, 220, 203, 213, 194, 149, 226, 81, 54, 225, 200, 170, 211, 6, 194, 162, 6, 186, 193, 205, 105, 147, 68, 39 } });
        }
    }
}
