using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 102, DateTimeKind.Local).AddTicks(8118),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 651, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(3788),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 100, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 649, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(7495),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 648, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 648, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(8354),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 647, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 647, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(7977),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 646, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(2185),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 646, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(1626),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(3601),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 644, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(8098),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 644, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 642, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(5249),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(9429),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 641, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 642, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(5459),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 641, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 91, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 640, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 103, DateTimeKind.Local).AddTicks(2982))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Views_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 31, 20, 103, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 6, 19, 31, 20, 103, DateTimeKind.Local).AddTicks(5422), new byte[] { 84, 149, 39, 159, 11, 183, 19, 131, 35, 187, 67, 40, 238, 164, 43, 8, 150, 26, 87, 106, 109, 6, 233, 239, 186, 19, 63, 56, 195, 136, 229, 139, 22, 3, 248, 108, 9, 124, 154, 19, 133, 218, 202, 202, 107, 37, 87, 44, 163, 79, 90, 224, 242, 6, 143, 56, 247, 166, 104, 95, 243, 3, 126, 208 }, new byte[] { 73, 118, 79, 57, 3, 130, 188, 81, 85, 119, 3, 235, 222, 172, 151, 155, 173, 165, 143, 90, 131, 46, 93, 176, 173, 251, 40, 204, 197, 140, 69, 8, 172, 68, 31, 236, 202, 221, 103, 245, 26, 163, 232, 101, 52, 65, 18, 142, 154, 239, 158, 48, 90, 19, 187, 120, 78, 161, 218, 223, 186, 169, 120, 156, 15, 115, 53, 28, 164, 126, 239, 152, 91, 99, 21, 224, 99, 202, 200, 18, 125, 173, 151, 120, 229, 133, 164, 168, 11, 161, 82, 176, 84, 22, 177, 195, 45, 240, 10, 139, 16, 239, 133, 240, 9, 183, 182, 64, 35, 218, 161, 42, 212, 214, 19, 237, 213, 129, 106, 59, 18, 138, 215, 192, 196, 188, 74, 189 } });

            migrationBuilder.CreateIndex(
                name: "IX_Views_BookId",
                table: "Views",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Views");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 651, DateTimeKind.Local).AddTicks(9375),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 102, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(8938),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(5687),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 650, DateTimeKind.Local).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 100, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 649, DateTimeKind.Local).AddTicks(1002),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 648, DateTimeKind.Local).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 648, DateTimeKind.Local).AddTicks(4778),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 647, DateTimeKind.Local).AddTicks(8985),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 647, DateTimeKind.Local).AddTicks(2000),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 646, DateTimeKind.Local).AddTicks(8210),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 646, DateTimeKind.Local).AddTicks(2384),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(6966),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(1724),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 644, DateTimeKind.Local).AddTicks(3633),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 644, DateTimeKind.Local).AddTicks(8301),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 642, DateTimeKind.Local).AddTicks(8779),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(5208),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 641, DateTimeKind.Local).AddTicks(9202),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 642, DateTimeKind.Local).AddTicks(4270),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 641, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 28, 32, 640, DateTimeKind.Local).AddTicks(9632),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 91, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 643, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 645, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 19, 28, 32, 652, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 12, 6, 19, 28, 32, 652, DateTimeKind.Local).AddTicks(5308), new byte[] { 42, 216, 134, 39, 52, 83, 141, 213, 89, 144, 230, 156, 169, 141, 205, 56, 140, 122, 23, 213, 122, 221, 130, 98, 40, 46, 97, 153, 86, 25, 194, 255, 219, 226, 102, 251, 118, 245, 235, 13, 83, 122, 62, 176, 14, 253, 152, 218, 151, 114, 24, 175, 70, 37, 109, 252, 96, 4, 172, 188, 9, 234, 139, 3 }, new byte[] { 120, 222, 76, 162, 87, 205, 61, 45, 99, 224, 236, 80, 225, 69, 114, 241, 177, 167, 243, 55, 15, 11, 207, 202, 177, 213, 228, 230, 21, 141, 14, 3, 176, 5, 86, 240, 70, 124, 127, 235, 92, 128, 90, 32, 185, 138, 210, 249, 172, 70, 210, 51, 158, 254, 246, 71, 230, 37, 51, 60, 210, 39, 97, 220, 146, 14, 27, 235, 223, 10, 11, 221, 123, 231, 126, 105, 82, 116, 7, 177, 111, 140, 48, 102, 217, 28, 89, 232, 69, 211, 241, 28, 129, 108, 112, 238, 22, 76, 213, 49, 35, 238, 88, 244, 33, 136, 91, 176, 99, 42, 215, 9, 51, 209, 166, 132, 11, 245, 76, 119, 129, 158, 182, 80, 48, 22, 229, 54 } });
        }
    }
}
