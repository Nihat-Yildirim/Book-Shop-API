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
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(7616),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(5271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 311, DateTimeKind.Local).AddTicks(6411),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 563, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(5131),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(8065),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 308, DateTimeKind.Local).AddTicks(3174),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 560, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(9083),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 559, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(1507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(9056),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(9240),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(629),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(7604),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(6669),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 552, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NeighbourhoodId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_NeighbourhoodId",
                table: "Addresses",
                column: "NeighbourhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Districts_DistrictId",
                table: "Addresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Neighbourhoods_NeighbourhoodId",
                table: "Addresses",
                column: "NeighbourhoodId",
                principalTable: "Neighbourhoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Districts_DistrictId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Neighbourhoods_NeighbourhoodId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_NeighbourhoodId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "NeighbourhoodId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(955),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 313, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 312, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 563, DateTimeKind.Local).AddTicks(8186),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 311, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(7703),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(5077),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 310, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(6827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(520),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 309, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 560, DateTimeKind.Local).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 308, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 559, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(9193),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 307, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(3111),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(14),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 306, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(6731),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 305, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(813),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 304, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(7105),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 303, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(3172),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 302, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(2973),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 552, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 16, 53, 21, 301, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Addresses",
                type: "VarChar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Addresses",
                type: "VarChar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(3602), new byte[] { 3, 85, 244, 230, 24, 93, 54, 68, 60, 10, 48, 99, 111, 66, 73, 60, 18, 241, 87, 249, 47, 91, 234, 4, 84, 191, 234, 24, 208, 86, 210, 215, 24, 176, 67, 126, 7, 169, 9, 240, 42, 70, 7, 194, 139, 114, 188, 205, 63, 66, 115, 244, 7, 50, 240, 133, 58, 209, 27, 182, 122, 111, 194, 202 }, new byte[] { 196, 92, 71, 81, 38, 146, 22, 141, 243, 220, 124, 234, 151, 201, 49, 61, 116, 139, 170, 3, 119, 223, 151, 208, 228, 69, 239, 152, 68, 70, 246, 48, 42, 88, 203, 217, 128, 143, 235, 65, 88, 15, 106, 156, 124, 190, 66, 143, 100, 47, 110, 187, 122, 121, 103, 160, 11, 229, 252, 132, 3, 64, 9, 102, 1, 175, 18, 237, 216, 20, 40, 170, 76, 243, 133, 63, 70, 160, 205, 93, 210, 102, 49, 190, 211, 105, 254, 200, 110, 198, 100, 246, 153, 116, 183, 120, 40, 113, 117, 244, 128, 38, 13, 149, 232, 121, 31, 134, 0, 15, 33, 80, 26, 93, 36, 197, 108, 167, 41, 105, 3, 99, 12, 215, 30, 235, 72, 53 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
