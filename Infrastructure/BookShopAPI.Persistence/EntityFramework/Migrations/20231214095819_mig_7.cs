using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 103, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 103, DateTimeKind.Local).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 102, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(5772),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 100, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(861),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(4890),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(8114),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(857),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(7078),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(2169),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(9588),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(5530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(1135),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 91, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.CreateTable(
                name: "BookSearchDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(2360))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSearchDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookSearchDatas_Books_BookId",
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

            migrationBuilder.CreateIndex(
                name: "IX_BookSearchDatas_BookId",
                table: "BookSearchDatas",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookSearchDatas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Views",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 103, DateTimeKind.Local).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 104, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 102, DateTimeKind.Local).AddTicks(8118),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 103, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 101, DateTimeKind.Local).AddTicks(3788),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 102, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 100, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 101, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(7495),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 99, DateTimeKind.Local).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 100, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(8354),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Neighbourhoods",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 98, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 99, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(7977),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 97, DateTimeKind.Local).AddTicks(2185),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 98, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 97, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 96, DateTimeKind.Local).AddTicks(1626),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(3601),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 95, DateTimeKind.Local).AddTicks(8098),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 96, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(8556),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(6992),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 95, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 94, DateTimeKind.Local).AddTicks(5249),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 94, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(9429),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 93, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 93, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 92, DateTimeKind.Local).AddTicks(5459),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 19, 31, 20, 91, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 12, 58, 19, 92, DateTimeKind.Local).AddTicks(2152));

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
        }
    }
}
