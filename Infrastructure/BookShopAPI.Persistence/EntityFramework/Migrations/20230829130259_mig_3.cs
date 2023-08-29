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
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 378, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 175, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<int>(
                name: "AuthenticatorType",
                table: "Users",
                type: "Int",
                maxLength: 1,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "Char(1)",
                oldMaxLength: 1,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 377, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 377, DateTimeKind.Local).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 376, DateTimeKind.Local).AddTicks(5997),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 173, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 375, DateTimeKind.Local).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 171, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 374, DateTimeKind.Local).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 170, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 374, DateTimeKind.Local).AddTicks(2319),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 168, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 373, DateTimeKind.Local).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 167, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 373, DateTimeKind.Local).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(6773),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(4650),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(3493),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 371, DateTimeKind.Local).AddTicks(5470),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 164, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(1292),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 370, DateTimeKind.Local).AddTicks(7804),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 371, DateTimeKind.Local).AddTicks(1754),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 370, DateTimeKind.Local).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 369, DateTimeKind.Local).AddTicks(9478),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 162, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(4650));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 175, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 378, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.AlterColumn<string>(
                name: "AuthenticatorType",
                table: "Users",
                type: "Char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "None",
                oldClrType: typeof(int),
                oldType: "Int",
                oldMaxLength: 1,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 377, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(3870),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 377, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 173, DateTimeKind.Local).AddTicks(6904),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 376, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 171, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 375, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 170, DateTimeKind.Local).AddTicks(1867),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 374, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 168, DateTimeKind.Local).AddTicks(6731),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 374, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 167, DateTimeKind.Local).AddTicks(5071),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 373, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 373, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(6777),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 164, DateTimeKind.Local).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 371, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 372, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(4294),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 370, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(8931),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 371, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 370, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 162, DateTimeKind.Local).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 2, 59, 369, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177));
        }
    }
}
