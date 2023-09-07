using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 176, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 454, DateTimeKind.Local).AddTicks(2922),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 175, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(9603),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 175, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 174, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "Char(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Char(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 452, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 174, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(5940),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 173, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(305),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 173, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 450, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 172, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(6596),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 170, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 170, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(3242),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(5113),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 445, DateTimeKind.Local).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 168, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(2725)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Türkçe", null },
                    { 2, "İngilizce", null }
                });

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(5295), new byte[] { 157, 231, 51, 22, 139, 163, 63, 235, 85, 74, 251, 74, 104, 133, 87, 167, 188, 4, 24, 216, 175, 152, 16, 218, 72, 125, 197, 66, 40, 50, 234, 59, 171, 218, 79, 29, 1, 16, 103, 170, 232, 207, 196, 125, 180, 175, 119, 65, 141, 88, 121, 211, 12, 160, 18, 209, 222, 203, 123, 27, 183, 148, 104, 107 }, new byte[] { 20, 102, 227, 81, 76, 202, 55, 255, 117, 226, 83, 208, 254, 165, 138, 228, 76, 120, 139, 153, 144, 175, 224, 247, 119, 6, 30, 253, 119, 160, 117, 24, 153, 81, 124, 219, 130, 78, 40, 215, 28, 24, 110, 65, 158, 184, 31, 30, 81, 166, 159, 249, 15, 158, 100, 54, 69, 95, 253, 12, 189, 243, 47, 142, 233, 203, 117, 10, 184, 183, 157, 127, 180, 168, 26, 37, 81, 24, 170, 243, 43, 171, 136, 98, 78, 91, 202, 81, 132, 133, 49, 197, 246, 253, 179, 96, 116, 75, 212, 7, 34, 64, 193, 250, 232, 155, 84, 65, 47, 9, 51, 77, 223, 157, 251, 111, 203, 15, 182, 127, 27, 209, 167, 55, 251, 109, 248, 150 } });

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Books_LanguageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 176, DateTimeKind.Local).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 455, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 175, DateTimeKind.Local).AddTicks(7101),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 454, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 175, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 174, DateTimeKind.Local).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 453, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "Char(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Char(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 174, DateTimeKind.Local).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 452, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 173, DateTimeKind.Local).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 173, DateTimeKind.Local).AddTicks(3367),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 451, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 172, DateTimeKind.Local).AddTicks(6870),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 450, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(4867),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 449, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(1333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 170, DateTimeKind.Local).AddTicks(2349),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "VarChar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 170, DateTimeKind.Local).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 448, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(4525),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(8532),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 447, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 169, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 446, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 31, 14, 35, 42, 168, DateTimeKind.Local).AddTicks(5317),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 5, 15, 42, 46, 445, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 14, 35, 42, 171, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 14, 35, 42, 176, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 35, 42, 176, DateTimeKind.Local).AddTicks(8328), new byte[] { 221, 137, 9, 20, 21, 159, 198, 125, 200, 197, 15, 240, 72, 146, 205, 77, 45, 32, 196, 192, 86, 20, 33, 164, 72, 218, 41, 175, 255, 31, 4, 57, 135, 231, 91, 98, 171, 182, 135, 126, 251, 221, 245, 60, 8, 249, 211, 162, 42, 117, 100, 235, 116, 124, 142, 158, 125, 241, 63, 112, 148, 55, 17, 215 }, new byte[] { 40, 34, 230, 123, 93, 213, 161, 49, 79, 20, 202, 138, 241, 143, 181, 195, 92, 84, 29, 175, 158, 137, 9, 252, 208, 28, 250, 29, 199, 126, 207, 111, 140, 18, 33, 171, 158, 133, 137, 175, 226, 156, 240, 248, 35, 221, 26, 171, 133, 157, 169, 46, 28, 102, 209, 233, 78, 113, 254, 64, 101, 211, 182, 191, 18, 179, 43, 230, 80, 184, 190, 221, 138, 123, 2, 86, 221, 254, 31, 129, 112, 244, 23, 125, 207, 17, 185, 112, 53, 214, 3, 199, 26, 192, 9, 224, 9, 148, 26, 39, 149, 178, 7, 18, 154, 56, 183, 178, 204, 223, 36, 150, 68, 212, 225, 254, 70, 110, 218, 196, 252, 146, 215, 75, 96, 69, 132, 56 } });
        }
    }
}
