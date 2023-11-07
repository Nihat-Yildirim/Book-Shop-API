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
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(4871),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(877),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 168, DateTimeKind.Local).AddTicks(2069),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 311, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 167, DateTimeKind.Local).AddTicks(2434),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(9962),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(5827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 165, DateTimeKind.Local).AddTicks(6204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(6481),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 308, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(2809),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 163, DateTimeKind.Local).AddTicks(5813),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(5799),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(4364),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(9459),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.AlterColumn<string>(
                name: "Dimension",
                table: "Books",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(8690),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(5567),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(3833),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 157, DateTimeKind.Local).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(7285), new byte[] { 119, 41, 246, 124, 228, 184, 11, 252, 121, 90, 188, 60, 119, 199, 48, 184, 60, 122, 10, 62, 12, 212, 159, 212, 172, 138, 157, 40, 82, 239, 109, 161, 104, 37, 60, 201, 43, 5, 237, 107, 92, 55, 165, 94, 252, 54, 177, 132, 116, 167, 236, 151, 8, 18, 9, 226, 166, 16, 36, 129, 44, 252, 31, 141 }, new byte[] { 80, 238, 5, 46, 124, 73, 154, 202, 16, 251, 150, 254, 155, 242, 101, 159, 120, 228, 203, 211, 117, 6, 147, 51, 48, 111, 253, 200, 159, 192, 242, 137, 21, 36, 177, 231, 4, 132, 167, 225, 2, 119, 150, 75, 113, 128, 168, 157, 253, 39, 92, 31, 198, 173, 107, 18, 208, 81, 55, 89, 62, 42, 108, 34, 55, 34, 28, 151, 84, 38, 152, 216, 218, 4, 136, 130, 4, 85, 197, 32, 73, 249, 118, 224, 40, 1, 141, 57, 31, 176, 52, 205, 148, 170, 125, 117, 118, 151, 176, 231, 57, 105, 245, 190, 117, 234, 182, 200, 38, 254, 157, 141, 150, 54, 233, 241, 120, 53, 236, 164, 62, 97, 70, 45, 172, 100, 237, 66 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(7616),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(5271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 311, DateTimeKind.Local).AddTicks(6411),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 168, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 167, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(5131),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(8065),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 165, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 308, DateTimeKind.Local).AddTicks(3174),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(9083),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(1507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 163, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(9056),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.AlterColumn<string>(
                name: "Dimension",
                table: "Books",
                type: "VarChar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(9240),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(629),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(7604),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(6669),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 157, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(9951), new byte[] { 107, 101, 107, 169, 215, 233, 51, 213, 130, 106, 110, 24, 118, 188, 189, 118, 25, 175, 132, 104, 89, 139, 6, 147, 2, 88, 34, 41, 5, 125, 28, 8, 146, 44, 176, 88, 30, 224, 137, 21, 254, 52, 60, 82, 83, 84, 223, 242, 101, 207, 98, 33, 29, 183, 137, 184, 210, 190, 177, 167, 86, 128, 178, 128 }, new byte[] { 83, 31, 241, 32, 16, 133, 189, 37, 68, 125, 36, 102, 242, 169, 50, 116, 248, 212, 167, 220, 121, 102, 183, 51, 114, 84, 191, 111, 51, 51, 218, 60, 245, 210, 198, 209, 173, 179, 40, 88, 57, 94, 251, 216, 211, 176, 105, 82, 216, 30, 105, 208, 78, 12, 46, 0, 90, 95, 254, 142, 186, 34, 55, 45, 200, 193, 53, 207, 234, 226, 168, 154, 232, 92, 124, 121, 166, 162, 94, 225, 128, 4, 171, 217, 11, 130, 82, 172, 6, 79, 111, 74, 57, 110, 8, 120, 15, 83, 121, 153, 51, 198, 24, 39, 14, 189, 65, 255, 122, 160, 157, 107, 4, 34, 181, 146, 113, 221, 232, 147, 104, 155, 54, 9, 123, 6, 36, 112 } });
        }
    }
}
