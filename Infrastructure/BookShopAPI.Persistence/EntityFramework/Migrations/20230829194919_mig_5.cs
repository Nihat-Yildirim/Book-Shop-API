using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 179, DateTimeKind.Local).AddTicks(1515),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 244, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 178, DateTimeKind.Local).AddTicks(2299),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 243, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 177, DateTimeKind.Local).AddTicks(9413),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 243, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 177, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 242, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 176, DateTimeKind.Local).AddTicks(6021),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 241, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 176, DateTimeKind.Local).AddTicks(2726),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 241, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 175, DateTimeKind.Local).AddTicks(9421),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 240, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 175, DateTimeKind.Local).AddTicks(4322),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 240, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 239, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 239, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(1105),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 173, DateTimeKind.Local).AddTicks(3218),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 173, DateTimeKind.Local).AddTicks(8982),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 237, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(9204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 237, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(2034),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 236, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 171, DateTimeKind.Local).AddTicks(7145),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 236, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate", "UserAvatarFileId" },
                values: new object[] { 1, new DateTime(2023, 8, 29, 22, 49, 19, 179, DateTimeKind.Local).AddTicks(3274), null, "BookShopAdmin@gmail.com", "Admin", "Admin", new byte[] { 137, 164, 239, 3, 228, 247, 215, 230, 139, 117, 119, 214, 150, 50, 9, 160, 24, 137, 236, 247, 10, 89, 26, 66, 115, 173, 83, 154, 158, 80, 210, 205, 181, 230, 150, 45, 26, 42, 103, 181, 46, 210, 106, 144, 225, 223, 86, 227, 62, 125, 93, 82, 213, 248, 69, 195, 49, 13, 206, 88, 194, 38, 185, 160 }, new byte[] { 180, 250, 210, 187, 173, 102, 158, 140, 44, 190, 132, 113, 27, 125, 171, 197, 179, 186, 175, 12, 133, 32, 11, 226, 194, 54, 71, 116, 154, 141, 174, 228, 235, 50, 133, 28, 207, 198, 67, 197, 97, 177, 203, 253, 227, 172, 34, 28, 50, 212, 98, 245, 211, 78, 196, 204, 164, 240, 168, 118, 34, 81, 43, 137, 8, 223, 239, 100, 118, 99, 215, 123, 82, 54, 113, 206, 141, 42, 52, 169, 225, 225, 225, 178, 238, 188, 249, 187, 235, 129, 207, 43, 19, 208, 28, 201, 99, 58, 148, 200, 178, 72, 211, 155, 32, 155, 167, 38, 122, 73, 133, 123, 18, 14, 169, 112, 25, 75, 43, 9, 199, 111, 79, 3, 229, 182, 90, 23 }, null, null });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimId", "UpdatedDate", "UserId" },
                values: new object[] { 1, 2, null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 244, DateTimeKind.Local).AddTicks(6092),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 179, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 243, DateTimeKind.Local).AddTicks(5947),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 178, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 243, DateTimeKind.Local).AddTicks(1957),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 177, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 242, DateTimeKind.Local).AddTicks(6084),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 177, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 241, DateTimeKind.Local).AddTicks(4690),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 176, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 241, DateTimeKind.Local).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 176, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 240, DateTimeKind.Local).AddTicks(7385),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 175, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 240, DateTimeKind.Local).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 175, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 239, DateTimeKind.Local).AddTicks(6979),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 239, DateTimeKind.Local).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(9429),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 174, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 173, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(6130),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 173, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 237, DateTimeKind.Local).AddTicks(2718),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 237, DateTimeKind.Local).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 236, DateTimeKind.Local).AddTicks(9341),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 172, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 16, 56, 57, 236, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 22, 49, 19, 171, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 16, 56, 57, 238, DateTimeKind.Local).AddTicks(9429));
        }
    }
}
