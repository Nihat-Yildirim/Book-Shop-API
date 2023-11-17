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
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PhoneNumbers_PhoneNumberId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PhoneNumberId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 389, DateTimeKind.Local).AddTicks(6188),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 91, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 388, DateTimeKind.Local).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 85, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 388, DateTimeKind.Local).AddTicks(2088),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 83, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 387, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 80, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(6546),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 74, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(4135),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 69, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 67, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 385, DateTimeKind.Local).AddTicks(2313),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 63, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 384, DateTimeKind.Local).AddTicks(5152),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 58, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 384, DateTimeKind.Local).AddTicks(1273),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 56, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 383, DateTimeKind.Local).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 52, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(9271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 47, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(3878),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 45, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(5401),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 41, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 43, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(409),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 29, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 34, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 379, DateTimeKind.Local).AddTicks(668),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 23, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 379, DateTimeKind.Local).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 26, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 378, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 20, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 378, DateTimeKind.Local).AddTicks(632),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 17, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Addresses",
                type: "Char(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 16, 21, 43, 37, 389, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 16, 21, 43, 37, 389, DateTimeKind.Local).AddTicks(8780), new byte[] { 118, 84, 186, 101, 191, 119, 124, 39, 67, 37, 129, 83, 84, 174, 229, 244, 247, 71, 112, 27, 26, 25, 42, 206, 248, 176, 97, 3, 207, 81, 170, 92, 200, 3, 78, 109, 151, 78, 53, 107, 79, 243, 70, 185, 93, 186, 209, 171, 195, 229, 195, 217, 236, 51, 164, 204, 4, 130, 249, 31, 242, 108, 162, 138 }, new byte[] { 186, 90, 44, 59, 155, 229, 32, 18, 164, 147, 125, 146, 175, 152, 207, 241, 184, 239, 7, 117, 192, 250, 93, 234, 225, 16, 148, 37, 80, 97, 194, 106, 203, 252, 241, 216, 82, 56, 233, 85, 197, 187, 24, 1, 89, 115, 133, 44, 241, 177, 126, 142, 72, 82, 212, 251, 93, 97, 213, 222, 107, 227, 166, 62, 40, 224, 208, 0, 94, 238, 207, 249, 230, 69, 128, 56, 41, 62, 254, 93, 73, 64, 186, 141, 213, 58, 250, 232, 63, 228, 108, 128, 156, 133, 222, 149, 85, 190, 114, 138, 76, 152, 217, 134, 15, 7, 116, 254, 103, 239, 118, 202, 120, 187, 114, 25, 204, 197, 235, 121, 100, 117, 36, 37, 4, 14, 121, 231 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 91, DateTimeKind.Local).AddTicks(8924),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 389, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 85, DateTimeKind.Local).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 388, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 83, DateTimeKind.Local).AddTicks(9762),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 388, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 80, DateTimeKind.Local).AddTicks(1463),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 387, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 74, DateTimeKind.Local).AddTicks(7610),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 69, DateTimeKind.Local).AddTicks(5798),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 67, DateTimeKind.Local).AddTicks(6498),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 386, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 63, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 385, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 58, DateTimeKind.Local).AddTicks(7443),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 384, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 56, DateTimeKind.Local).AddTicks(5452),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 384, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 52, DateTimeKind.Local).AddTicks(5704),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 383, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 49, DateTimeKind.Local).AddTicks(5597),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 47, DateTimeKind.Local).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 45, DateTimeKind.Local).AddTicks(7685),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 41, DateTimeKind.Local).AddTicks(937),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 43, DateTimeKind.Local).AddTicks(7502),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 382, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(8491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 381, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 35, DateTimeKind.Local).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 29, DateTimeKind.Local).AddTicks(3798),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 34, DateTimeKind.Local).AddTicks(647),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 380, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 23, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 379, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 26, DateTimeKind.Local).AddTicks(8245),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 379, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 20, DateTimeKind.Local).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 378, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 17, DateTimeKind.Local).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 21, 43, 37, 378, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 11, 9, 13, 50, 58, 72, DateTimeKind.Local).AddTicks(9732)),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "Char(10)", maxLength: 10, nullable: false),
                    PhoneTitle = table.Column<string>(type: "VarChar(45)", maxLength: 45, nullable: true),
                    Selected = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PhoneNumberId",
                table: "Orders",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "PhoneNumbers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PhoneNumbers_PhoneNumberId",
                table: "Orders",
                column: "PhoneNumberId",
                principalTable: "PhoneNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
