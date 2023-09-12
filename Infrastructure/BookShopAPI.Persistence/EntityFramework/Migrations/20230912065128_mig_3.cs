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
            migrationBuilder.DropTable(
                name: "OrderPhoneNumber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 929, DateTimeKind.Local).AddTicks(5539),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 928, DateTimeKind.Local).AddTicks(5528),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 905, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 928, DateTimeKind.Local).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 927, DateTimeKind.Local).AddTicks(6531),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 926, DateTimeKind.Local).AddTicks(7124),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 926, DateTimeKind.Local).AddTicks(3333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 925, DateTimeKind.Local).AddTicks(9212),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 902, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 925, DateTimeKind.Local).AddTicks(1549),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumberId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 923, DateTimeKind.Local).AddTicks(6130),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 923, DateTimeKind.Local).AddTicks(366),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(4989),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(2263),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(9890),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(8387),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(124),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 919, DateTimeKind.Local).AddTicks(6139),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 919, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 896, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 9, 51, 27, 929, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 12, 9, 51, 27, 929, DateTimeKind.Local).AddTicks(8091), new byte[] { 197, 255, 157, 137, 56, 125, 25, 67, 188, 253, 111, 71, 61, 26, 99, 254, 84, 126, 165, 68, 98, 141, 186, 123, 70, 221, 179, 178, 39, 41, 200, 6, 37, 41, 186, 216, 35, 182, 179, 0, 126, 204, 55, 115, 248, 186, 88, 231, 57, 59, 115, 142, 77, 188, 77, 148, 154, 143, 160, 173, 176, 67, 167, 120 }, new byte[] { 185, 49, 132, 134, 142, 69, 177, 93, 212, 80, 123, 239, 149, 8, 19, 210, 247, 193, 146, 33, 49, 120, 77, 121, 11, 139, 98, 17, 139, 84, 185, 249, 40, 203, 94, 219, 148, 181, 57, 28, 194, 28, 191, 128, 114, 224, 143, 4, 95, 219, 79, 200, 219, 157, 70, 49, 198, 102, 156, 240, 49, 81, 226, 23, 122, 77, 57, 48, 11, 128, 63, 76, 175, 99, 160, 141, 115, 232, 62, 160, 46, 193, 66, 162, 229, 133, 66, 87, 210, 22, 204, 21, 19, 184, 227, 154, 71, 119, 215, 52, 166, 195, 118, 74, 66, 137, 188, 206, 94, 226, 216, 248, 93, 39, 53, 95, 197, 65, 243, 243, 106, 51, 104, 177, 193, 203, 252, 81 } });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PhoneNumberId",
                table: "Orders",
                column: "PhoneNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PhoneNumbers_PhoneNumberId",
                table: "Orders",
                column: "PhoneNumberId",
                principalTable: "PhoneNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PhoneNumbers_PhoneNumberId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PhoneNumberId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumberId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 929, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 905, DateTimeKind.Local).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 928, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 928, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 904, DateTimeKind.Local).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 927, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 926, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 903, DateTimeKind.Local).AddTicks(362),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 926, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 902, DateTimeKind.Local).AddTicks(5709),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 925, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(9066),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 925, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 901, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 923, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(5071),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 923, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 922, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(4337),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(2070),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 921, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 898, DateTimeKind.Local).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 920, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 897, DateTimeKind.Local).AddTicks(3865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 919, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 12, 41, 33, 896, DateTimeKind.Local).AddTicks(8637),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 9, 51, 27, 919, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.CreateTable(
                name: "OrderPhoneNumber",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumbersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPhoneNumber", x => new { x.OrdersId, x.PhoneNumbersId });
                    table.ForeignKey(
                        name: "FK_OrderPhoneNumber_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPhoneNumber_PhoneNumbers_PhoneNumbersId",
                        column: x => x.PhoneNumbersId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 899, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 900, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 41, 33, 906, DateTimeKind.Local).AddTicks(5189), new byte[] { 9, 39, 75, 114, 222, 219, 221, 133, 245, 82, 170, 133, 35, 181, 42, 153, 247, 79, 90, 243, 181, 190, 109, 212, 251, 139, 28, 50, 95, 115, 224, 218, 57, 169, 24, 217, 252, 6, 174, 191, 4, 77, 33, 51, 135, 194, 234, 104, 190, 32, 211, 158, 152, 64, 230, 61, 37, 27, 153, 25, 59, 170, 166, 41 }, new byte[] { 31, 230, 32, 226, 66, 141, 60, 100, 183, 251, 67, 83, 127, 152, 60, 137, 175, 158, 56, 230, 219, 15, 130, 201, 1, 207, 187, 139, 175, 33, 121, 165, 137, 211, 227, 150, 150, 75, 2, 24, 29, 194, 14, 46, 213, 142, 254, 65, 88, 161, 166, 88, 226, 82, 169, 147, 88, 29, 126, 83, 16, 43, 224, 138, 116, 98, 228, 134, 18, 132, 44, 200, 58, 233, 146, 222, 103, 189, 51, 224, 87, 43, 37, 209, 94, 178, 144, 195, 252, 111, 233, 253, 100, 236, 176, 106, 124, 140, 240, 86, 70, 253, 184, 213, 38, 209, 46, 149, 154, 34, 220, 50, 39, 239, 134, 69, 132, 99, 95, 231, 223, 253, 76, 225, 191, 75, 232, 105 } });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPhoneNumber_PhoneNumbersId",
                table: "OrderPhoneNumber",
                column: "PhoneNumbersId");
        }
    }
}
