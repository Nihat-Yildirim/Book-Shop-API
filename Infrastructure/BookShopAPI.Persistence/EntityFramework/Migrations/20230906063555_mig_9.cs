using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 537, DateTimeKind.Local).AddTicks(9615),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 530, DateTimeKind.Local).AddTicks(5821),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 362, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 530, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 529, DateTimeKind.Local).AddTicks(6932),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 528, DateTimeKind.Local).AddTicks(5607),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 360, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 528, DateTimeKind.Local).AddTicks(1494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 527, DateTimeKind.Local).AddTicks(8093),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 527, DateTimeKind.Local).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(9951),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(7825),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(6603),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 524, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 523, DateTimeKind.Local).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 524, DateTimeKind.Local).AddTicks(3537),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 523, DateTimeKind.Local).AddTicks(4975),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 522, DateTimeKind.Local).AddTicks(8696),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 6, 9, 35, 55, 538, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 6, 9, 35, 55, 538, DateTimeKind.Local).AddTicks(2520), new byte[] { 110, 42, 160, 220, 147, 233, 24, 79, 224, 212, 216, 228, 233, 21, 74, 110, 154, 242, 112, 23, 134, 84, 240, 239, 142, 145, 157, 134, 13, 101, 53, 114, 87, 240, 31, 145, 21, 232, 142, 236, 2, 228, 120, 251, 53, 157, 196, 122, 124, 83, 90, 152, 237, 131, 144, 226, 22, 166, 142, 6, 167, 21, 134, 234 }, new byte[] { 245, 199, 178, 16, 254, 108, 26, 196, 149, 12, 183, 205, 95, 1, 144, 220, 127, 113, 122, 225, 12, 48, 45, 106, 51, 27, 8, 13, 152, 180, 143, 6, 204, 128, 220, 150, 43, 110, 3, 181, 7, 113, 126, 195, 254, 233, 230, 172, 147, 131, 178, 12, 103, 129, 136, 69, 174, 199, 152, 100, 74, 66, 88, 20, 90, 239, 238, 110, 140, 148, 158, 195, 214, 182, 184, 5, 212, 124, 87, 207, 145, 203, 235, 136, 52, 24, 106, 218, 81, 84, 185, 52, 12, 150, 41, 89, 143, 156, 154, 157, 3, 57, 228, 178, 119, 197, 247, 151, 249, 117, 68, 94, 124, 29, 177, 84, 36, 252, 128, 145, 137, 70, 162, 114, 63, 241, 184, 113 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 363, DateTimeKind.Local).AddTicks(4075),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 537, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 362, DateTimeKind.Local).AddTicks(2643),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 530, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 530, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 361, DateTimeKind.Local).AddTicks(3232),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 529, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 360, DateTimeKind.Local).AddTicks(3020),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 528, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 528, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 359, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 527, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 527, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 358, DateTimeKind.Local).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 526, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 357, DateTimeKind.Local).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 524, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 356, DateTimeKind.Local).AddTicks(8328),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 525, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(1543),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 523, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 355, DateTimeKind.Local).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 524, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(7557),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 523, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 9, 33, 47, 354, DateTimeKind.Local).AddTicks(1822),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 9, 35, 55, 522, DateTimeKind.Local).AddTicks(8696));

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
    }
}
