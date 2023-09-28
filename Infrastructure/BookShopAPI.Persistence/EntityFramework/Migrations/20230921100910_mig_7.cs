using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Authors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 392, DateTimeKind.Local).AddTicks(162),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 390, DateTimeKind.Local).AddTicks(4839),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 390, DateTimeKind.Local).AddTicks(1903),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 389, DateTimeKind.Local).AddTicks(7208),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 923, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 922, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(5346),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(2266),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 387, DateTimeKind.Local).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 386, DateTimeKind.Local).AddTicks(9403),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 920, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 386, DateTimeKind.Local).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 919, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(9181),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(6666),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(87),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(4126),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 383, DateTimeKind.Local).AddTicks(5125),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(1111),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 382, DateTimeKind.Local).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 383, DateTimeKind.Local).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 382, DateTimeKind.Local).AddTicks(3255),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Authors",
                type: "VarChar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 381, DateTimeKind.Local).AddTicks(7542),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 9, 10, 392, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 21, 13, 9, 10, 392, DateTimeKind.Local).AddTicks(2376), new byte[] { 223, 194, 180, 152, 11, 128, 22, 99, 114, 65, 17, 23, 82, 196, 135, 191, 136, 110, 245, 254, 175, 254, 109, 68, 52, 197, 102, 64, 255, 222, 231, 84, 108, 49, 200, 83, 30, 233, 32, 49, 180, 183, 25, 183, 41, 91, 220, 147, 241, 192, 82, 72, 178, 189, 117, 0, 135, 18, 200, 178, 160, 83, 97, 135 }, new byte[] { 99, 28, 236, 101, 157, 248, 66, 106, 252, 9, 180, 2, 55, 158, 239, 139, 179, 196, 228, 27, 13, 152, 132, 94, 72, 92, 52, 160, 125, 34, 153, 230, 57, 231, 219, 65, 113, 5, 44, 243, 53, 53, 18, 16, 48, 197, 2, 13, 179, 96, 144, 74, 239, 167, 153, 15, 52, 175, 224, 0, 18, 219, 187, 152, 128, 240, 99, 100, 83, 104, 51, 216, 148, 195, 83, 48, 42, 58, 209, 84, 126, 56, 83, 225, 153, 103, 52, 46, 110, 204, 219, 170, 43, 76, 240, 221, 200, 21, 138, 149, 198, 213, 228, 6, 41, 164, 79, 46, 23, 56, 20, 227, 159, 145, 229, 160, 229, 169, 62, 89, 96, 56, 2, 50, 61, 112, 50, 115 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Authors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 392, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 390, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(1093),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 390, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 923, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 389, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 922, DateTimeKind.Local).AddTicks(4912),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 388, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(205),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 387, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 920, DateTimeKind.Local).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 386, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 919, DateTimeKind.Local).AddTicks(5377),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 386, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(6913),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 385, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(2930),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 383, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 384, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(3819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 382, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 383, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 382, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "VarChar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 9, 10, 381, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(9940), new byte[] { 202, 187, 186, 136, 174, 188, 232, 77, 42, 124, 98, 157, 191, 51, 96, 142, 199, 117, 30, 9, 109, 214, 19, 225, 25, 16, 223, 150, 36, 233, 179, 158, 202, 51, 223, 125, 29, 74, 113, 20, 185, 119, 133, 20, 221, 56, 232, 178, 71, 125, 239, 130, 161, 175, 26, 254, 254, 84, 88, 194, 47, 198, 31, 140 }, new byte[] { 103, 166, 2, 92, 159, 236, 12, 136, 199, 242, 241, 141, 138, 101, 117, 140, 23, 5, 224, 128, 243, 25, 226, 92, 199, 246, 169, 6, 242, 97, 103, 232, 133, 125, 197, 125, 170, 120, 219, 116, 149, 16, 126, 173, 4, 20, 90, 95, 91, 252, 255, 204, 204, 229, 148, 124, 21, 192, 86, 83, 250, 146, 77, 221, 28, 152, 41, 121, 23, 96, 61, 128, 80, 68, 34, 12, 71, 20, 213, 68, 26, 229, 125, 152, 18, 99, 134, 207, 67, 237, 93, 140, 80, 211, 195, 247, 126, 18, 14, 241, 10, 26, 222, 176, 244, 127, 88, 130, 69, 120, 19, 143, 8, 9, 215, 82, 217, 153, 208, 60, 14, 94, 156, 94, 156, 99, 246, 44 } });
        }
    }
}
