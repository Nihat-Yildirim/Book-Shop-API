using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(4075),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 362, DateTimeKind.Local).AddTicks(2643),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 454, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(3232),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 360, DateTimeKind.Local).AddTicks(3020),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 452, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 450, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(8328),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(1543),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(7557),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(1822),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 445, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(6328), new byte[] { 246, 87, 63, 100, 73, 31, 205, 235, 32, 82, 50, 22, 187, 172, 180, 199, 69, 169, 203, 226, 175, 9, 96, 123, 188, 121, 106, 107, 35, 251, 106, 105, 28, 205, 253, 24, 219, 109, 102, 48, 34, 180, 175, 235, 135, 90, 171, 230, 227, 67, 162, 124, 192, 196, 197, 151, 232, 61, 247, 214, 133, 72, 202, 127 }, new byte[] { 141, 153, 130, 88, 50, 33, 6, 71, 119, 185, 55, 228, 83, 34, 209, 155, 226, 118, 160, 59, 81, 179, 201, 65, 226, 148, 61, 195, 220, 59, 127, 101, 78, 193, 36, 91, 219, 97, 211, 144, 219, 255, 131, 133, 170, 164, 71, 227, 162, 163, 13, 152, 43, 4, 152, 18, 170, 134, 209, 70, 95, 86, 57, 120, 140, 181, 72, 112, 145, 22, 54, 232, 251, 245, 27, 19, 149, 11, 145, 245, 40, 227, 9, 128, 221, 155, 208, 64, 38, 232, 50, 16, 74, 17, 14, 213, 152, 224, 5, 79, 138, 108, 133, 252, 244, 26, 96, 169, 130, 186, 87, 78, 253, 231, 72, 49, 174, 230, 64, 193, 50, 136, 248, 135, 28, 97, 77, 216 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 454, DateTimeKind.Local).AddTicks(2922),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 362, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(9603),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 452, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 360, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(5940),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(305),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 450, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(2725),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(6596),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(3242),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(5113),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 445, DateTimeKind.Local).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(5295), new byte[] { 157, 231, 51, 22, 139, 163, 63, 235, 85, 74, 251, 74, 104, 133, 87, 167, 188, 4, 24, 216, 175, 152, 16, 218, 72, 125, 197, 66, 40, 50, 234, 59, 171, 218, 79, 29, 1, 16, 103, 170, 232, 207, 196, 125, 180, 175, 119, 65, 141, 88, 121, 211, 12, 160, 18, 209, 222, 203, 123, 27, 183, 148, 104, 107 }, new byte[] { 20, 102, 227, 81, 76, 202, 55, 255, 117, 226, 83, 208, 254, 165, 138, 228, 76, 120, 139, 153, 144, 175, 224, 247, 119, 6, 30, 253, 119, 160, 117, 24, 153, 81, 124, 219, 130, 78, 40, 215, 28, 24, 110, 65, 158, 184, 31, 30, 81, 166, 159, 249, 15, 158, 100, 54, 69, 95, 253, 12, 189, 243, 47, 142, 233, 203, 117, 10, 184, 183, 157, 127, 180, 168, 26, 37, 81, 24, 170, 243, 43, 171, 136, 98, 78, 91, 202, 81, 132, 133, 49, 197, 246, 253, 179, 96, 116, 75, 212, 7, 34, 64, 193, 250, 232, 155, 84, 65, 47, 9, 51, 77, 223, 157, 251, 111, 203, 15, 182, 127, 27, 209, 167, 55, 251, 109, 248, 150 } });
        }
    }
}
