using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 175, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 822, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(3870),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 173, DateTimeKind.Local).AddTicks(6904),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 819, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 171, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 818, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 170, DateTimeKind.Local).AddTicks(1867),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 168, DateTimeKind.Local).AddTicks(6731),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(6777),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 164, DateTimeKind.Local).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(4294),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(8931),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 162, DateTimeKind.Local).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 813, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.CreateTable(
                name: "MailComfirmCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ComfirmCode = table.Column<string>(type: "Char(6)", maxLength: 6, nullable: false),
                    IsComfirm = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    ComfirmDuration = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 167, DateTimeKind.Local).AddTicks(5071)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailComfirmCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailComfirmCodes_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailComfirmCodes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 822, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 175, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(6151),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(556),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 819, DateTimeKind.Local).AddTicks(4462),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 173, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 818, DateTimeKind.Local).AddTicks(2584),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 171, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(9006),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 170, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(5644),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 168, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(103),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(5109),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(1723),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(3380),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 164, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(9411),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(5446),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(9501),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(1971),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 813, DateTimeKind.Local).AddTicks(6724),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 58, 47, 162, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(2990));
        }
    }
}
