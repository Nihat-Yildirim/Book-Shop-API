using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 525, DateTimeKind.Local).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 524, DateTimeKind.Local).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 523, DateTimeKind.Local).AddTicks(7648),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 523, DateTimeKind.Local).AddTicks(1781),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 346, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 522, DateTimeKind.Local).AddTicks(1671),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 521, DateTimeKind.Local).AddTicks(7725),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 521, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 520, DateTimeKind.Local).AddTicks(7572),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 344, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 519, DateTimeKind.Local).AddTicks(8694),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 519, DateTimeKind.Local).AddTicks(2513),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(6850),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.AlterColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
                type: "Int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "Int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 516, DateTimeKind.Local).AddTicks(8539),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 515, DateTimeKind.Local).AddTicks(9071),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 516, DateTimeKind.Local).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 514, DateTimeKind.Local).AddTicks(9640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 515, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 514, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 513, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 10, 38, 23, 525, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 13, 10, 38, 23, 525, DateTimeKind.Local).AddTicks(4463), new byte[] { 147, 155, 58, 230, 11, 234, 132, 56, 24, 139, 169, 140, 211, 166, 99, 51, 138, 163, 52, 19, 76, 47, 255, 103, 171, 116, 48, 184, 87, 23, 22, 150, 143, 141, 96, 235, 248, 73, 35, 251, 149, 220, 213, 92, 5, 15, 14, 40, 232, 82, 242, 14, 116, 232, 32, 1, 254, 37, 28, 68, 25, 87, 51, 10 }, new byte[] { 150, 215, 103, 155, 152, 43, 2, 91, 12, 64, 73, 72, 28, 55, 16, 227, 59, 54, 186, 131, 199, 130, 171, 201, 34, 183, 88, 82, 246, 91, 3, 151, 163, 195, 73, 224, 54, 108, 205, 147, 148, 108, 149, 99, 86, 229, 196, 93, 44, 68, 40, 88, 45, 126, 128, 131, 248, 16, 8, 38, 212, 207, 210, 99, 118, 167, 168, 184, 123, 81, 138, 93, 253, 158, 104, 191, 253, 202, 116, 234, 28, 5, 82, 227, 56, 37, 221, 196, 1, 22, 150, 230, 148, 234, 61, 230, 81, 119, 207, 115, 168, 182, 80, 18, 62, 68, 149, 41, 163, 45, 240, 140, 208, 123, 205, 61, 59, 19, 121, 115, 254, 243, 111, 35, 123, 12, 28, 119 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 364, DateTimeKind.Local).AddTicks(6245),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 525, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(7982),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 524, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 347, DateTimeKind.Local).AddTicks(4551),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 523, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 346, DateTimeKind.Local).AddTicks(9007),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 523, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(9353),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 522, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(5564),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 521, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 345, DateTimeKind.Local).AddTicks(1787),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 521, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 344, DateTimeKind.Local).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 520, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(7599),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 519, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 343, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 519, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 342, DateTimeKind.Local).AddTicks(1833),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
                type: "Int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "Int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(4452),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 341, DateTimeKind.Local).AddTicks(9442),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 518, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(8555),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 517, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(7135),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 516, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 515, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 340, DateTimeKind.Local).AddTicks(4758),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 516, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(9486),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 514, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 339, DateTimeKind.Local).AddTicks(3915),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 515, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(5678),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 514, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 10, 30, 43, 338, DateTimeKind.Local).AddTicks(235),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 10, 38, 23, 513, DateTimeKind.Local).AddTicks(9870));

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
    }
}
