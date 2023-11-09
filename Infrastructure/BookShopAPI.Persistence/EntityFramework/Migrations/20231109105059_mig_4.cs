using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 91, DateTimeKind.Local).AddTicks(8924),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 85, DateTimeKind.Local).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 83, DateTimeKind.Local).AddTicks(9762),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 80, DateTimeKind.Local).AddTicks(1463),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 168, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 74, DateTimeKind.Local).AddTicks(7610),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 167, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 72, DateTimeKind.Local).AddTicks(9732),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 69, DateTimeKind.Local).AddTicks(5798),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 67, DateTimeKind.Local).AddTicks(6498),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 63, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 165, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 58, DateTimeKind.Local).AddTicks(7443),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 56, DateTimeKind.Local).AddTicks(5452),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 52, DateTimeKind.Local).AddTicks(5704),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 163, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 47, DateTimeKind.Local).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 45, DateTimeKind.Local).AddTicks(7685),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 41, DateTimeKind.Local).AddTicks(937),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 43, DateTimeKind.Local).AddTicks(7502),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 29, DateTimeKind.Local).AddTicks(3798),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 34, DateTimeKind.Local).AddTicks(647),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 23, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 26, DateTimeKind.Local).AddTicks(8245),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "BasketItems",
                type: "Bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 20, DateTimeKind.Local).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 17, DateTimeKind.Local).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 157, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 13, 50, 58, 92, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 9, 13, 50, 58, 93, DateTimeKind.Local).AddTicks(292), new byte[] { 146, 143, 197, 246, 79, 195, 86, 33, 189, 112, 141, 207, 185, 233, 195, 181, 94, 118, 126, 61, 204, 149, 15, 202, 45, 32, 237, 115, 175, 91, 236, 20, 214, 118, 109, 31, 91, 73, 198, 211, 76, 141, 170, 140, 56, 123, 209, 135, 113, 70, 139, 42, 0, 129, 50, 211, 201, 36, 125, 169, 5, 212, 121, 161 }, new byte[] { 96, 108, 96, 148, 142, 134, 98, 66, 100, 153, 3, 230, 104, 213, 147, 135, 159, 232, 102, 63, 145, 48, 75, 126, 160, 120, 235, 86, 251, 81, 144, 103, 170, 85, 244, 12, 24, 78, 193, 122, 74, 62, 78, 208, 148, 80, 125, 220, 227, 160, 85, 251, 208, 212, 153, 86, 125, 195, 15, 215, 89, 40, 11, 154, 40, 215, 17, 150, 121, 121, 221, 131, 56, 86, 238, 18, 138, 184, 137, 195, 135, 48, 174, 55, 171, 65, 47, 141, 18, 49, 88, 28, 245, 230, 166, 0, 28, 61, 179, 101, 168, 221, 218, 237, 70, 167, 33, 194, 109, 3, 195, 16, 35, 228, 181, 130, 139, 226, 10, 214, 255, 197, 102, 28, 255, 66, 51, 225 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Selected",
                table: "BasketItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 170, DateTimeKind.Local).AddTicks(4871),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 91, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 85, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 169, DateTimeKind.Local).AddTicks(877),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 83, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 168, DateTimeKind.Local).AddTicks(2069),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 80, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 167, DateTimeKind.Local).AddTicks(2434),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 74, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(9962),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 72, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(5827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 69, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 166, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 67, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 165, DateTimeKind.Local).AddTicks(6204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 63, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(6481),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 58, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 164, DateTimeKind.Local).AddTicks(2809),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 56, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 163, DateTimeKind.Local).AddTicks(5813),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 52, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(8640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(5799),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 47, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 162, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 45, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(4364),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 41, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 161, DateTimeKind.Local).AddTicks(9459),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 43, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(8690),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 29, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 160, DateTimeKind.Local).AddTicks(5567),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 34, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 23, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 159, DateTimeKind.Local).AddTicks(3833),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 26, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 158, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 20, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 17, 59, 15, 157, DateTimeKind.Local).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 17, DateTimeKind.Local).AddTicks(5865));

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
    }
}
