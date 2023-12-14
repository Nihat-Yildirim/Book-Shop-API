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
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 721, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 720, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 103, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 716, DateTimeKind.Local).AddTicks(9341),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(7423),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(3618),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 714, DateTimeKind.Local).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(5968),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(9735),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 708, DateTimeKind.Local).AddTicks(8418),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 709, DateTimeKind.Local).AddTicks(6663),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 702, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 707, DateTimeKind.Local).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(3505),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 700, DateTimeKind.Local).AddTicks(7474),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.CreateTable(
                name: "AuthorSearchDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(7369))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorSearchDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorSearchDatas_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 16, 30, 40, 722, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 30, 40, 722, DateTimeKind.Local).AddTicks(2561), new byte[] { 245, 53, 44, 62, 123, 173, 234, 167, 37, 206, 89, 33, 77, 233, 186, 168, 98, 42, 155, 230, 115, 229, 69, 119, 16, 246, 188, 8, 170, 141, 241, 54, 188, 134, 166, 67, 118, 182, 4, 155, 186, 198, 110, 206, 11, 159, 203, 23, 240, 148, 187, 180, 55, 120, 231, 171, 156, 224, 204, 192, 114, 205, 17, 75 }, new byte[] { 117, 128, 20, 30, 162, 198, 144, 62, 251, 7, 152, 0, 193, 162, 2, 143, 251, 220, 96, 73, 153, 120, 196, 205, 33, 17, 74, 194, 210, 40, 174, 81, 165, 67, 238, 172, 14, 141, 137, 71, 42, 8, 94, 37, 81, 46, 233, 14, 127, 49, 118, 248, 249, 162, 79, 184, 139, 93, 238, 138, 45, 47, 103, 238, 18, 58, 82, 132, 108, 95, 5, 167, 120, 142, 159, 243, 16, 81, 1, 185, 12, 196, 158, 60, 219, 10, 231, 59, 56, 175, 26, 24, 90, 205, 44, 226, 142, 13, 74, 179, 63, 253, 253, 137, 240, 91, 63, 80, 72, 55, 109, 172, 150, 8, 38, 192, 178, 126, 91, 250, 39, 94, 68, 35, 16, 69, 231, 32 } });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSearchDatas_AuthorId",
                table: "AuthorSearchDatas",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorSearchDatas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 721, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 103, DateTimeKind.Local).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 720, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(5772),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 716, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(861),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(4890),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(8114),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 714, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(857),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(7078),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(2169),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(9588),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(5530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(2360),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(1135),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 708, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 709, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 702, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 707, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 700, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(4718), new byte[] { 134, 29, 2, 118, 133, 168, 94, 150, 245, 206, 194, 12, 41, 211, 176, 33, 150, 162, 71, 42, 100, 48, 200, 120, 70, 88, 118, 173, 78, 164, 157, 160, 58, 77, 40, 233, 92, 245, 188, 207, 35, 199, 239, 5, 78, 182, 7, 161, 45, 49, 212, 15, 17, 116, 123, 92, 72, 15, 109, 148, 162, 111, 207, 22 }, new byte[] { 167, 75, 69, 58, 171, 37, 16, 214, 212, 201, 137, 37, 237, 202, 35, 92, 13, 252, 150, 176, 123, 147, 55, 169, 114, 225, 74, 49, 19, 67, 248, 169, 232, 195, 235, 145, 132, 237, 146, 112, 208, 48, 62, 117, 220, 24, 66, 235, 80, 84, 40, 58, 113, 87, 99, 248, 220, 56, 181, 204, 249, 47, 57, 152, 216, 160, 232, 26, 43, 240, 145, 13, 114, 215, 103, 106, 6, 167, 48, 202, 230, 123, 74, 49, 206, 187, 5, 142, 129, 246, 140, 165, 129, 233, 179, 110, 80, 246, 141, 243, 161, 118, 55, 144, 78, 34, 25, 63, 72, 76, 145, 119, 159, 55, 16, 179, 127, 201, 20, 74, 56, 47, 129, 117, 247, 188, 19, 199 } });
        }
    }
}
