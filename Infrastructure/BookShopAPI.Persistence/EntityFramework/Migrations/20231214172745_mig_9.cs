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
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(8119),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 721, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 720, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(3958),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(315),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 716, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(9728),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(7157),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 365, DateTimeKind.Local).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 714, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(6887),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(195),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 363, DateTimeKind.Local).AddTicks(1414),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(9173),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(4064),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(3497),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(3811),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(2096),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 708, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(9844),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 709, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(924),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 702, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 707, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AuthorSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(6338),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(1859),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 355, DateTimeKind.Local).AddTicks(5383),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 700, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.CreateTable(
                name: "PublisherSearchDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(4316))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherSearchDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublisherSearchDatas_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 27, 45, 371, DateTimeKind.Local).AddTicks(639), new byte[] { 141, 39, 247, 135, 65, 49, 128, 193, 109, 222, 176, 144, 177, 95, 123, 246, 216, 107, 217, 225, 42, 138, 171, 87, 93, 16, 181, 45, 153, 176, 106, 165, 7, 28, 244, 57, 103, 38, 85, 170, 140, 132, 60, 92, 183, 54, 153, 120, 6, 75, 60, 95, 254, 108, 227, 246, 184, 184, 15, 87, 34, 81, 142, 237 }, new byte[] { 157, 75, 34, 237, 207, 230, 145, 138, 165, 195, 110, 152, 16, 236, 30, 196, 127, 217, 217, 54, 248, 28, 9, 149, 84, 102, 193, 86, 107, 147, 4, 146, 72, 136, 49, 175, 30, 252, 102, 227, 67, 23, 95, 201, 254, 96, 98, 142, 67, 164, 146, 178, 71, 202, 138, 186, 173, 92, 175, 59, 210, 2, 204, 35, 221, 103, 2, 192, 238, 188, 44, 65, 92, 111, 201, 210, 180, 229, 11, 39, 145, 131, 33, 46, 178, 24, 152, 76, 107, 39, 161, 0, 157, 61, 220, 158, 88, 55, 165, 185, 161, 62, 171, 173, 106, 26, 217, 51, 46, 25, 213, 125, 158, 39, 220, 189, 66, 102, 78, 152, 234, 174, 1, 215, 64, 115, 141, 91 } });

            migrationBuilder.CreateIndex(
                name: "IX_PublisherSearchDatas_PublisherId",
                table: "PublisherSearchDatas",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublisherSearchDatas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 721, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 720, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 717, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 716, DateTimeKind.Local).AddTicks(9341),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(7423),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 715, DateTimeKind.Local).AddTicks(3618),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 714, DateTimeKind.Local).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 365, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 713, DateTimeKind.Local).AddTicks(5968),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(9735),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 363, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(3782),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 712, DateTimeKind.Local).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 711, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(3660),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 710, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 708, DateTimeKind.Local).AddTicks(8418),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 709, DateTimeKind.Local).AddTicks(6663),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 702, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 707, DateTimeKind.Local).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AuthorSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(7369),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 701, DateTimeKind.Local).AddTicks(3505),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 16, 30, 40, 700, DateTimeKind.Local).AddTicks(7474),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 355, DateTimeKind.Local).AddTicks(5383));

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
        }
    }
}
