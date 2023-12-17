using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 455, DateTimeKind.Local).AddTicks(2565),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 454, DateTimeKind.Local).AddTicks(8587),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 453, DateTimeKind.Local).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 453, DateTimeKind.Local).AddTicks(3249),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PublisherSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 452, DateTimeKind.Local).AddTicks(7331),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 452, DateTimeKind.Local).AddTicks(3148),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 451, DateTimeKind.Local).AddTicks(2363),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 450, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 450, DateTimeKind.Local).AddTicks(5616),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 449, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 365, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 448, DateTimeKind.Local).AddTicks(9423),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 448, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 447, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 363, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(6079),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(2970),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 445, DateTimeKind.Local).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 444, DateTimeKind.Local).AddTicks(4280),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 445, DateTimeKind.Local).AddTicks(653),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(6320),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(2363),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 442, DateTimeKind.Local).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 442, DateTimeKind.Local).AddTicks(7608),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 441, DateTimeKind.Local).AddTicks(5115),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AuthorSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(1177),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 439, DateTimeKind.Local).AddTicks(4669),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 355, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(297))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 51, 24, 455, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 51, 24, 455, DateTimeKind.Local).AddTicks(5221), new byte[] { 237, 146, 82, 93, 19, 74, 149, 110, 236, 217, 238, 29, 135, 187, 251, 188, 26, 209, 164, 26, 39, 85, 238, 162, 156, 27, 19, 156, 249, 178, 180, 43, 41, 196, 218, 61, 241, 54, 0, 207, 55, 116, 95, 230, 215, 55, 90, 81, 72, 239, 207, 250, 111, 159, 182, 114, 224, 204, 184, 246, 185, 85, 110, 255 }, new byte[] { 173, 143, 222, 118, 109, 53, 21, 158, 187, 169, 173, 151, 128, 90, 34, 115, 157, 197, 29, 23, 248, 199, 109, 84, 81, 60, 131, 77, 142, 40, 26, 118, 152, 105, 183, 220, 197, 158, 8, 47, 28, 247, 199, 56, 120, 207, 19, 162, 46, 209, 30, 145, 20, 201, 69, 213, 81, 144, 168, 198, 122, 226, 177, 123, 244, 186, 143, 3, 251, 60, 133, 97, 229, 22, 193, 11, 164, 18, 232, 162, 103, 186, 155, 157, 252, 212, 199, 131, 245, 4, 234, 102, 189, 244, 108, 91, 98, 254, 243, 110, 112, 117, 123, 200, 66, 27, 3, 147, 178, 215, 37, 244, 0, 244, 218, 248, 165, 140, 97, 189, 77, 44, 146, 114, 177, 82, 228, 179 } });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookId",
                table: "FavoriteBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserId",
                table: "FavoriteBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(8119),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 455, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 370, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 454, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(3958),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 453, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 369, DateTimeKind.Local).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 453, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PublisherSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(4316),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 452, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 368, DateTimeKind.Local).AddTicks(315),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 452, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(9728),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 451, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(7157),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 450, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 366, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 450, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 365, DateTimeKind.Local).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 449, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(6887),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 448, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 364, DateTimeKind.Local).AddTicks(195),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 448, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 363, DateTimeKind.Local).AddTicks(1414),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 447, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 362, DateTimeKind.Local).AddTicks(4585),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(9173),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 446, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 361, DateTimeKind.Local).AddTicks(4064),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 445, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(3497),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 444, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 360, DateTimeKind.Local).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 445, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(7251),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 359, DateTimeKind.Local).AddTicks(3811),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 443, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(2096),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 442, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 358, DateTimeKind.Local).AddTicks(9844),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 442, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(924),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 357, DateTimeKind.Local).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 441, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AuthorSearchDatas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(6338),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 356, DateTimeKind.Local).AddTicks(1859),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 440, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 27, 45, 355, DateTimeKind.Local).AddTicks(5383),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 17, 13, 51, 24, 439, DateTimeKind.Local).AddTicks(4669));

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
        }
    }
}
